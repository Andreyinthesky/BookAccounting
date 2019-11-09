using System.Collections.Generic;

namespace BookAccounting
{
    public static class Localization
    {
        public static Dictionary<string, string> localNamesBook = new Dictionary<string, string>
        {
            {"Id", "Id"},
            {"Автор", "AuthorName"},
            {"Название", "BookName"},
            {"Издательство", "PublishingOfficeName"},
            {"Тематика", "Theme"},
            {"Год", "Year"},
            {"Кол-во страниц", "PageCount"},
            {"ISBN", "ISBN"},
            {"Текущее кол-во", "Count"},
            {"Стеллаж", "CabinetName"},
            {"Полка", "RackName"}
        };

        public static Dictionary<string, string> localNamesReaders = new Dictionary<string, string>
        {
            {"Id", "Id"},
            {"Фамилия", "Surname"},
            {"Имя", "Name"},
            {"Отчество", "Patronymic"},
            {"Номер телефона", "PhoneNumber"},
            {"Эл. почта", "Email"},
        };

        public static Dictionary<string, string> localNamesIssuedBooksView = new Dictionary<string, string>
        {
            {"Id", "Id"},
            {"Дата выдачи", "DateIssue"},
            {"Дата возврата", "DateReturn"},
            {"Id книги", "IdBook"},
            {"Автор", "AuthorName"},
            {"Название", "BookName"},
            {"Id читателя", "IdReader"},
            {"Фамилия", "Surname"},
            {"Имя", "Name"},
            {"Отчество", "Patronymic"}
        };
    }
}
