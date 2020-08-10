using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BookService.Data
{
    public class Contexto<TEntity> : IDisposable where TEntity : class
    {
        private string arquivo = string.Concat(Path.GetFullPath(@"Json"), @"\book.json");

        public List<TEntity> Dados()
        {
            var retorno = new List<TEntity>();
            if (!File.Exists(arquivo))
            {
                return null;
            }
            using (StreamReader read = new StreamReader(arquivo))
            {
                string json = read.ReadToEnd();

                retorno = JsonConvert.DeserializeObject<List<TEntity>>(json, new JsonSerializerSettings() { Culture = new CultureInfo("pt-BR") });
            }
            return retorno;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
