using Bussiness.Abstract;
using Data_Access.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorsDal _colorsDal;

        public ColorManager(IColorsDal colorsDal)
        {
            this._colorsDal = colorsDal;
        }

        public void AddColor(Colors color)
        {
            _colorsDal.Add(color);
        }

        public void DeleteColor(Colors color)
        {
            _colorsDal.Delete(color);
        }

        public List<Colors> GetAllColors()
        {
            return _colorsDal.GetAll();
        }

        public void UpdateColor(Colors color)
        {
            _colorsDal.Update(color);
        }
    }
}
