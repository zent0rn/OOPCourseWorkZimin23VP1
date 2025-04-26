using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;


/// <summary>
/// Класс для генерации отчётов в PDF
/// </summary>
public class PdfReportGenerator
{
    /// <summary>
    /// Сгенерировать отчёт по мебели
    /// </summary>
    /// <param name="data">Таблица данных о мебели</param>
    public static void GenerateFurnitureReport(DataTable data)
    {
        GenerateReport(data, "Отчет по мебели", "Мебель", ReportColumnConfigs.FurnitureColumns);
    }

    /// <summary>
    /// Сгенерировать отчёт по помещениям
    /// </summary>
    /// <param name="data">Таблица данных о помещениях</param>
    public static void GenerateRoomsReport(DataTable data)
    {
        GenerateReport(data, "Отчет по помещениям", "Помещения", ReportColumnConfigs.RoomColumns);
    }

    /// <summary>
    /// Сгенерировать отчёт по ответственным лицам
    /// </summary>
    /// <param name="data">Таблица данных о ответственных лицах</param>
    public static void GeneratePersonsReport(DataTable data)
    {
        GenerateReport(data, "Отчет по ответственным лицам", "Ответственные лица", ReportColumnConfigs.PersonColumns);
    }

    /// <summary>
    /// Сгенерировать отчёт
    /// </summary>
    /// <param name="data">Таблица данных</param>
    /// <param name="title">Заголовок</param>
    /// <param name="fileName">Название файла</param>
    /// <param name="columnConfigs">Названия столбцов</param>
    public static void GenerateReport(DataTable data, string title, string fileName, Dictionary<string, ColumnConfig> columnConfigs)
    {
        // Настройка шрифтов для русского языка
        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
        BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        Font titleFont = new Font(baseFont, 20, Font.BOLD);
        Font normalFont = new Font(baseFont, 10, Font.NORMAL);

        using (SaveFileDialog saveDialog = new SaveFileDialog())
        {
            saveDialog.Filter = "PDF файлы (*.pdf)|*.pdf";
            saveDialog.Title = "Сохранить отчет как";
            saveDialog.FileName = $"{fileName}_{DateTime.Now:yyyy_MM_dd_HH_mm}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                    document.Open();

                    // Заголовок с русским текстом
                    Paragraph header = new Paragraph(title, titleFont);
                    header.Alignment = Element.ALIGN_CENTER;
                    header.SpacingAfter = 18;
                    document.Add(header);

                    // Создаем таблицу только с видимыми колонками
                    var visibleColumns = data.Columns.Cast<DataColumn>()
                        .Where(c => columnConfigs.ContainsKey(c.ColumnName)
                               && columnConfigs[c.ColumnName].IsVisible)
                        .ToList();

                    PdfPTable table = new PdfPTable(visibleColumns.Count)
                    {
                        WidthPercentage = 100
                    };

                    // Заголовки столбцов
                    foreach (DataColumn column in visibleColumns)
                    {
                        string headerText = columnConfigs[column.ColumnName].DisplayName;

                        PdfPCell cell = new PdfPCell(new Phrase(headerText, normalFont))
                        {
                            BackgroundColor = new BaseColor(200, 200, 200)
                        };
                        table.AddCell(cell);
                    }

                    // Данные таблицы
                    foreach (DataRow row in data.Rows)
                    {
                        foreach (DataColumn column in visibleColumns)
                        {
                            table.AddCell(new Phrase(row[column]?.ToString() ?? "", normalFont));
                        }
                    }
                    //table.SpacingAfter = 15;

                    document.Add(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании отчета: {ex.Message}");
                }
                finally
                {
                    document.Close();
                }

                // Автоматическое открытие PDF
                OpenPdfFile(saveDialog.FileName);
            }
        }
    }

    /// <summary>
    /// Метод для открытия pdf файла
    /// </summary>
    /// <param name="filePath">Путь к файлу</param>
    private static void OpenPdfFile(string filePath)
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось открыть PDF: {ex.Message}");
        }
    }
}

/// <summary>
/// Класс для настроек стоблцов таблиц
/// </summary>
public class ColumnConfig
{
    /// <summary>
    /// Отображаемое название
    /// </summary>
    public string DisplayName { get; set; }
    /// <summary>
    /// Видна ли таблица
    /// </summary>
    public bool IsVisible { get; set; } = true;
}

/// <summary>
/// Статический класс с данными о столбцах таблиц
/// </summary>
public static class ReportColumnConfigs
{
    public static readonly Dictionary<string, ColumnConfig> FurnitureColumns = new()
    {
        ["ID"] = new ColumnConfig { DisplayName = "ID" },
        ["Name"] = new ColumnConfig { DisplayName = "Название" },
        ["Type"] = new ColumnConfig { DisplayName = "Тип" },
        ["Material"] = new ColumnConfig { DisplayName = "Основной материал" },
        ["MadeByCountry"] = new ColumnConfig { DisplayName = "Страна производства" },
        ["Room_ID"] = new ColumnConfig { DisplayName = "ID помещения" },
        ["Price"] = new ColumnConfig { DisplayName = "Цена, руб." },
        ["ValueInRoom"] = new ColumnConfig { DisplayName = "Количество" }
    };

    public static readonly Dictionary<string, ColumnConfig> RoomColumns = new()
    {
        ["ID"] = new ColumnConfig { DisplayName = "ID" },
        ["Name"] = new ColumnConfig { DisplayName = "Название помещения" },
        ["Address"] = new ColumnConfig { DisplayName = "Адрес" },
        ["Area"] = new ColumnConfig { DisplayName = "Площадь (м²)" },
        ["Responsible_Person_ID"] = new ColumnConfig { DisplayName = "ID Ответственного" }
    };

    public static readonly Dictionary<string, ColumnConfig> PersonColumns = new()
    {
        ["ID"] = new ColumnConfig { DisplayName = "ID" },
        ["FullName"] = new ColumnConfig { DisplayName = "ФИО" },
        ["Phone"] = new ColumnConfig { DisplayName = "Телефон" },
        ["Email"] = new ColumnConfig { DisplayName = "Email" }
    };
}