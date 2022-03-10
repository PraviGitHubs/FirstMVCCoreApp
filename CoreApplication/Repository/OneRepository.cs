using CoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Repository
{
    public class OneRepository
    {
        public List<OneModel> GetAll() {
            return DataSource();
        }

        public OneModel GetOnebyId(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<OneModel> SearchOne(string title, string author)
        {
            return DataSource().Where(x => x.Name.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<OneModel> DataSource()
        {
            return new List<OneModel>()
            { 
                new OneModel() { Id = 1 , Name = "Name 1" , Author = "Author 1" , Description="Thisis the description for 1"},
                new OneModel() { Id = 2 , Name = "Name 2" , Author = "Author 2" , Description="Thisis the description for 2"},
                new OneModel() { Id = 3 , Name = "Name 3" , Author = "Author 3" , Description="Thisis the description for 3"},
                new OneModel() { Id = 4 , Name = "Name 4" , Author = "Author 4" , Description="Thisis the description for 4"},
                new OneModel() { Id = 5 , Name = "Name 5" , Author = "Author 5", Description="Thisis the description for 5"},
                new OneModel() { Id = 5 , Name = "Name 6" , Author = "Author 6", Description="Thisis the description for 6"},
                new OneModel() { Id = 5 , Name = "Name 7" , Author = "Author 7", Description="Thisis the description for 7"},
            };
        }
    }
}
