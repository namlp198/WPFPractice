using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyPropertyDemo
{
    public class Student : DependencyObject
    {
        public int Age
        {
            get { return (int)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(int), typeof(Student), new PropertyMetadata(6, new PropertyChangedCallback(AgeChangedCallback),
                new CoerceValueCallback(AgeCoerceCallback)), new ValidateValueCallback(AgeValidateCallback));

        private static bool AgeValidateCallback(object value)
        {
            if(value is int)
            {
                int age = (int)value;
                return age >= 0;
            }
            return false;
        }

        private static object AgeCoerceCallback(DependencyObject d, object baseValue)
        {
            int age = (int)baseValue;
            if (age < 6)
                age = 6;
            else if (age > 50)
                age = 50;
            return age;
        }

        private static void AgeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show($"Age da duoc thay doi tu 6 thanh {d.GetValue(AgeProperty)}");
        }
    }
}
