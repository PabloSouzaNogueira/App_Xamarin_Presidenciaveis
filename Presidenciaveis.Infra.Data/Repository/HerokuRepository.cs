using Newtonsoft.Json;
using Presidenciaveis.Domain.Interfaces;
using Presidenciaveis.Domain.ModelBase;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Presidenciaveis.Infra.Data.Repository
{
    public class HerokuRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        readonly string RoutePrefix = "https://votocerto.herokuapp.com/";

        public HerokuRepository(string entidade)
        {
            RoutePrefix += (entidade + "/");
        }

        public async Task<TEntity> RequestFindByIdAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                string resultJson = await httpClient.GetStringAsync(url);
                var data = JsonConvert.DeserializeObject<TEntity>(resultJson);

                return data;
            }
        }

        public async Task<IEnumerable<TEntity>> RequestGetAllAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string resultJson = await httpClient.GetStringAsync(RoutePrefix);
                var data = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(resultJson);

                return data;
            }
        }

       

        public Task<TEntity> Find(string id)
        {
            return RequestFindByIdAsync(RoutePrefix + id);
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            return RequestGetAllAsync();
        }

        public Task Delete(TEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetFirst()
        {
            throw new NotImplementedException();
        }

        public Task Insert(TEntity tEntity)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity tEntity)
        {
            throw new NotImplementedException();
        }
    }
}
