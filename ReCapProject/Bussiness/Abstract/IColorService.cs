using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        List<Colors> GetAllColors();
        void UpdateColor(Colors color);
        void DeleteColor(Colors color);
        void AddColor(Colors color);
    }
}
