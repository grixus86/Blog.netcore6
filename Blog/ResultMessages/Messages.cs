namespace Blog.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} The article titled has been successfully added.";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} The article titled has been successfully updated.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} The article titled has been successfully deleted.";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} The article titled has been successfully retracted.";
            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} The article category has been successfully added.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} The article category has been successfully updated.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} The article category has been successfully deleted.";
            }
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} The category titled has been successfully withdrawn.";
            }
        }
        public static class User
        {
            public static string Add(string userName)
            {
                return $"{userName} User with email address has been added successfully.";
            }
            public static string Update(string userName)
            {
                return $"{userName} The user with the email address has been successfully updated.";
            }
            public static string Delete(string userName)
            {
                return $"{userName} The user with the email address has been successfully deleted.";
            }
        }
    }
}
