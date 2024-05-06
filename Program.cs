using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Thirteenth_lesson
{

    public class Program
    {
        public static List<string> Distinct(List<string> values)
        {
            HashSet<string> result = new HashSet<string>();

            if (values == null)
            {
                return result.ToList();
            }
            if (values.Count == 0)
            {
                return result.ToList();
            }

            result.Add(values[0]);
            foreach (string value in values)
            {
                if (!result.Contains(value))
                {
                    result.Add(value);
                }
            }
            return result.ToList();
        }

        //Реализовать следующие методы:

        //Метод возвращает первое слово из последовательности слов, содержащее только одну букву.

        public static string GetWordWithOneLetter(List<string> words)
        {

            if (words == null)
            {
                return "Массив слов пустой";

            }
            if (words.Count == 0)
            {
                return "Массив пустой";
            }

            string word = words.FirstOrDefault(q => q.Length == 1);

            if (word == null)
            {
                return "Слово с одной буковй нет";
            }
            return word;
        }

        //Метод, возвращающий последнее слово, содержащее в себе подстроку «ее».
        //Реализовать, используя только 1 метод LINQ.

        public static string GetLastWordWhereTherEE(List<string> words)
        {

            if (words == null)
            {
                return "Массив слов пустой";

            }
            if (words.Count == 0)
            {
                return "Массив пустой";
            }
            var word = words.Where(q => q.Contains("ee")).LastOrDefault();

            if (word == null)
            {
                return "Слово с подстракой 'ее' нет";
            }
            return word;
        }

        //Реализовать метод для возврата последнего слова, соответствующего условию:
        //Длина слова не меньше min и не больше max.Если нет слов, соответствующих условию, метод возвращает null.

        public static string GetLastWordWhereMaxCountMinCoint(List<string> words, int countWordMax, int cointWordMin)
        {

            if (words == null)
            {
                return "Массив слов пустой";

            }
            if (words.Count == 0)
            {
                return "Массив пустой";
            }
            var word = words.Where(q => q.Length <= countWordMax && q.Length >= cointWordMin).LastOrDefault();


            return word;
        }

        //Напишите метод, который возвращает количество уникальных значений в массиве.

        public static int NumberOfUniqueValuesInTheArray(List<string> words)
        {
            var uniqueValues = words.Distinct().ToList();
            return uniqueValues.Count();
        }

        //Напишите метод, который принимает список и извлекает значения от 5 (включительно) оканчивающееся по значению то, которое содержит цифру "3"
        //Не понял условие...............

        //Метод возвращает длину самого короткого слова

        public static int ShortestWord(List<string> words)
        {
            var countShortestWord = words.Min(q => q.Length);
            return countShortestWord;
        }

        //Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение

        public static List<KeyValuePair<string, int>> ConversDictionaryToList(Dictionary<int, string> dictionary)
        {
            List<KeyValuePair<string, int>> list = dictionary.Select(q => new KeyValuePair<string, int>(q.Value, q.Key)).ToList();
            return list;
        }


        //Напишите метод, который возвращает предоставленный список пользователей,
        //упорядоченный по LastName в порядке убывания.
        public static List<User> GetSortUserForLastName(List<User> users)
        {
            return users.OrderByDescending(q => q.LastName).ToList();
        }



        static void Main(string[] args)
        {

            List<string> words = ["asda", "asda", "gdf", "aseeg", "fgfaeds"];


            //Console.WriteLine(GetWordWithOneLetter(words));

            //Console.WriteLine(GetLastWordWhereTherEE(words));

            //Console.WriteLine(GetLastWordWhereMaxCountMinCoint(words,1,1));

            //Console.WriteLine(NumberOfUniqueValuesInTheArray(words));

            //Console.WriteLine(ShortestWord(words));

            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            //myDictionary.Add(1, "One");
            //myDictionary.Add(2, "Two");
            //myDictionary.Add(3, "Three");

            //var lists = ConversDictionaryToList(myDictionary);

            //foreach (var list in lists)
            //{
            //    Console.WriteLine($"{list.Key} - ключm, {list.Value} - значение");
            //}



            List<User> users = new List<User>()
            {
                new User("Oleg","Olegovich","Olegov"),
                new User("Aleksand","Aleksandrovvv","Aleksandrovich"),
                new User("Maksim","Maksimov","Maksimovich")
            };

            var userSort = GetSortUserForLastName(users);
            foreach (var user in (userSort))
            {
                Console.WriteLine(user.LastName);
            }






            //  List<Product> productsOne = new List<Product>()
            //  {
            //  new Product()
            //  {
            //      Categories = ["First1","First2","First3","First1"],
            //      Price = 123,
            //  },
            //new Product()
            //  {
            //      Categories = ["First1","First2","First3","First5"],
            //      Price = 123,
            //  },new Product()
            //  {
            //      Categories = ["First1","First2","First3","First6"],
            //      Price = 123,
            //  },

            //  };


            //  //4.
            //  List<string> strings = ["First1", "First2", "First2", "First6"];

            //  Console.WriteLine(string.Join(",", Distinct(strings)));





            //3.
            //List<string> categoriesSort = new List<string>();

            //foreach (var product in productsOne)
            //{

            //    foreach (var category in product.Categories)
            //    {
            //        categoriesSort.Add(category);

            //    }
            //}

            //Console.WriteLine(string.Join(",", categoriesSort.Distinct().ToList()));

            //var prodSort = productsOne.SelectMany(q=>q.Categories).Distinct().ToList();

            //Console.WriteLine(string.Join(",", prodSort));



            //2.

            //foreach (var item in productsTwo.ExceptBy(productsOne.Select(q=>q.Category),x=>x.Category))
            //{
            //    Console.WriteLine(item.Price);

            //}


            // 1.

            //var result = productsOne.GroupBy(p => p.Category).ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Average(q => q.Price));


            //}


        }
    }
}
