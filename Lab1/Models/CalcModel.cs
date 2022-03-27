namespace Lab1.Models
{
    /// <summary>
    /// Модель для вычислений
    /// </summary>
    public class WebCalcModel
    {
        /// <summary>
        /// Первое число
        /// </summary>
        public int FirstValue { get; set; }
        /// <summary>
        /// Второе число
        /// </summary>
        public int SecondValue { get; set; }
        /// <summary>
        /// Результат вычисления. В качестве ключа - название операции.
        /// </summary>
        public List<CalcResult> CalcResults { get; set; }
    }
}
