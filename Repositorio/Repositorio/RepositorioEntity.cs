using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Repositorio.ViewModel;
namespace Repositorio.Repositorio
{
    public class RepositorioEntity<TModelo, TViewModel> :
        IRepositorio<TModelo, TViewModel> where TModelo : class
                                 where TViewModel : IViewModel<TModelo>, new()
    {
        public TViewModel Add(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public int Borrar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public int Borrar(Expression<Func<TModelo, bool>> consulta)
        {
            throw new NotImplementedException();
        }

        public int Actualizar(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<TViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public TViewModel Get(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public ICollection<TViewModel> Get(Expression<Func<TModelo, bool>> consulta)
        {
            throw new NotImplementedException();
        }
    }
}
