using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 派生类(子类):圆形
    /// </summary>
    class Circle:Shape
    {
        public Circle()
        {

        }

        /// <summary>
        /// 圆形构造函数
        /// 初始化颜色值
        /// </summary>
        /// <param name="Color">颜色</param>
        public Circle(string Color)
        {
            this.Color = Color;
        }
    }
}
