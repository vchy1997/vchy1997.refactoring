using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.FactoryMehtod
{
    /// <summary>
    /// 汽车抽象类
    /// </summary>
    public abstract class Car
    {
        /// <summary>
        /// 获取汽车品牌
        /// </summary>
        public abstract string GetCarBrand();
    }
}
