namespace MathUtil.Formula
{
    /// <summary>
    /// Wallis の公式
    /// </summary>
    public class WallisFormula
    {
        /// <summary>
        /// 計算を実行する
        /// </summary>
        /// <param name="count">計算回数(この値が大きくなりすぎると死ぬ)</param>
        /// <returns>計算結果</returns>
        public static double Conpute(int count)
        {
            double pi = 1;
            for (int i = 1; i <= count; i++)
            {
                int n = 4 * i * i;
                pi *= (double)n / (n - 1);
            }
            return 2 * pi;
        }
    }
}
