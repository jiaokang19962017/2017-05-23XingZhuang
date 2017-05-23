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
        /// <summary>
        /// 半径
        /// </summary>
        protected double Radius;
        public Circle()
        {

        }

        /// <summary>
        /// 圆形构造函数
        /// 初始化颜色值
        /// </summary>
        /// <param name="Color">颜色</param>
        /// <param name="Radius">半径</param>
        public Circle(string Color,double Radius)
        {
            this.Radius = Radius;
            this.Color = Color;
        }

        /// <summary>
        /// 获取圆形的面积
        /// </summary>
        /// <returns>返回面积</returns>
        public double GetArea()
        {
           
            return Math.Pow(Radius, 2) * Math.PI;
        }

        /// <summary>
        /// 获取圆的周长
        /// </summary>
        /// <returns>返回周长</returns>
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
