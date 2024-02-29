using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс для валидации
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Валидатор строковых переменных
        /// </summary>
        /// <param name="value">Переменная</param>
        /// <param name="maxLength">Максимальная длина</param>
        /// <param name="propertyName">Название переменной</param>
        /// <returns>Возвращает переменную, если она прошла валидацию</returns>
        /// <exception cref="ArgumentException">Вызывает исключение, если переменная не прошла валидацию</exception>

        public string AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value == null || value == "")
            {
                throw new ArgumentException($"{propertyName} должен быть не пустым");
            }
            else if (value.Length > maxLength)
            {
                
                throw new ArgumentException($"{propertyName} превышен лимит");
            }
            else
            {
                return value;
            }
        }
    }
}
