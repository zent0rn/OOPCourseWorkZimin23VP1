﻿using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using OOPCourseWorkZimin23VP1.dbServices;

namespace OOPCourseWorkZimin23VP1.tools
{
    /// <summary>
    /// Репозиторий ответственных лиц. 
    /// Для взаимодействия с таблицей ответственных лиц.
    /// </summary>
    class ResponsiblePersonRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        /// <summary>
        /// Конструктор. Создаётся контекст БД.
        /// </summary>
        public ResponsiblePersonRepository()
        {
            _db = DatabaseService.CreateContext();
        }

        /// <summary>
        /// Получить контекст БД
        /// </summary>
        /// <returns>контекст БД</returns>
        public FurnitureDBContext getDb()
        {
            return _db;
        }
        /// <summary>
        /// Получить данные об ответственных лицах в виде списка
        /// </summary>
        /// <returns></returns>
        public List<ResponsiblePerson> LoadData()
        {
            return _db.ResponsiblePerson.ToList();
        }

        /// <summary>
        /// Найти ответственных лиц по критериям
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phone">Телефон</param>
        /// <param name="email">Почта</param>
        /// <returns>Список ответственных лиц</returns>
        public List<ResponsiblePerson> SearchPersons(string name = null, string phone = null, string email = null)
        {
            _db.ChangeTracker.Clear();
            IQueryable<ResponsiblePerson> query = _db.ResponsiblePerson
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(r => r.FullName.Contains(name));
            }
            if (!string.IsNullOrWhiteSpace(phone))
            {
                query = query.Where(r => r.Phone.Contains(phone));
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(r => r.Email.Contains(email));
            }

            return query.ToList();
        }

        /// <summary>
        /// Добавить ответственное лицо 
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phone">Телефон</param>
        /// <param name="email">Почта</param>
        /// <returns>true, если успешно, false - в обратном случае</returns>
        public bool AddPerson(string name, string phone, string email)
        {
            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(phone) &&
                !string.IsNullOrWhiteSpace(email))
            {
                ResponsiblePerson Person = new ResponsiblePerson
                {
                    FullName = name,
                    Phone = phone,
                    Email = email
                };

                _db.ResponsiblePerson.Add(Person);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Удалить ответственное лицо
        /// </summary>
        /// <param name="id">ID ответственного лица</param>
        /// <returns>true, если успешно, иначе - false</returns>
        public bool DeletePerson(int id)
        {
            // Загружаем комнату вместе с мебелью
            var person = _db.ResponsiblePerson
                .Include(r => r.Rooms) // Явная загрузка
                .FirstOrDefault(r => r.ID == id);

            if (person != null)
            {
                // Удаляем мебель, если она есть
                if (person.Rooms != null && person.Rooms.Any())
                {
                    _db.Room.RemoveRange(person.Rooms);
                }

                _db.ResponsiblePerson.Remove(person);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Удалить все ответственные лица
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllResponsiblePersons()
        {
            try
            {
                var allPersons = _db.ResponsiblePerson.ToList();
                if (!allPersons.Any())
                {
                    return true; // Таблица уже пуста
                }

                _db.ResponsiblePerson.RemoveRange(allPersons);
                return _db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении ответственных лиц: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Редактировать ответственное лицо
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Имя</param>
        /// <param name="phone">Телефон</param>
        /// <param name="email">Почта</param>
        /// <returns>true, если успешно, иначе - false</returns>
        public bool EditPerson(int id, string name, string phone, string email)
        {
            _db.ChangeTracker.Clear();
            var person = _db.ResponsiblePerson.Find(id);

            if (person == null) return false;

            person.FullName = name;
            person.Phone = phone;
            person.Email = email;

            _db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
