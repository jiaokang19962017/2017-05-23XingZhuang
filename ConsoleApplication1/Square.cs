using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /// <summary>
    /// 矩形类的子类:
    /// </summary>
    class Square:Rectangular
    {

        /// <summary>
        /// 正方形的构造函数
        /// </summary>
        /// <param name="Color">颜色</param>
        public Square(string Color)
        {
            this.Color = Color;
        }
        /// <summary>
        /// 获取正方形的面积
        /// </summary>
        /// <returns>返回面积</returns>
        public new double GetArea()//new可以隐藏父类的方法,重新设置
        {
            return Length * Weight;
        }

        /// <summary>
        /// 获取正方形的周长
        /// </summary>
        /// <returns>返回周长</returns>
        public new double GetPerimeter()
        {
            return Length * 4;
        }
    }
}
