using System;
using System.Collections.Generic;

namespace MilestoneTG.Linq
{
    /// <summary>
    /// Provides extension methods for classes implementing the IEnumerable interface.
    /// </summary>
    public static class IEnumerableExtensions
	{
		#region Variance()
		/*********************************************************************************************************
		 * The variance is equal to the mean of the square minus the square of the mean:
		 *   Var(X) = E[X2] - E[X]2
		 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
		 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
		 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
		 * Therefore the variance is 7.5 − 6.25 = 1.25 
		 ********************************************************************************************************/


        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The variance</returns>
        /// <example>
        /// <code lang="C#">
        /// double[] numbers = new double[] {1.0, 2.0, 3.0, 4.0, 5.0};
        /// double theVariance = numbers.Variance();
        /// </code>
        /// </example>
		public static double Variance(this IEnumerable<int> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
        	foreach (int num in source)
        	{   
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="selector">The selector.</param>
        /// <returns></returns>
		public static double Variance<TSource> (this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
		
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
			int num = 0;
			
        	foreach (var element in source)
        	{   
				num = selector(element);
				
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The variance</returns>	
        public static double Variance(this IEnumerable<long> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
        	foreach (long num in source)
        	{   
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);			
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The variance</returns>	
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
			long num = 0;
			
        	foreach (var element in source)
        	{   
				num = selector(element);
				
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The variance</returns>	
        public static double Variance(this IEnumerable<double> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
        	foreach (double num in source)
        	{   
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);			
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The variance</returns>	
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			double meanOfTheSquare = 0.0;

        	double mean = 0;
			
			int count = 0;
			
			double num = 0;
			
        	foreach (var element in source)
        	{   
				num = selector(element);
				
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The variance</returns>	
        public static float Variance(this IEnumerable<float> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			float meanOfTheSquare = 0.0F;

        	float mean = 0F;
			
			int count = 0;
			
        	foreach (float num in source)
        	{   
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return (float)Math.Round(meanOfTheSquare - (mean * mean),7);			
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The variance</returns>	
        public static float Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			float meanOfTheSquare = 0F;

        	float mean = 0F;
			
			int count = 0;
			
			float num = 0F;
			
        	foreach (var element in source)
        	{   
				num = selector(element);
				
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return (float)Math.Round(meanOfTheSquare - (mean * mean), 7);
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The variance</returns>	
        public static decimal Variance(this IEnumerable<decimal> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			decimal meanOfTheSquare = 0.0M;

        	decimal mean = 0M;
			
			int count = 0;
			
        	foreach (decimal num in source)
        	{   
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);			
		}

        /// <summary>
        /// Computes the statistical variance
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The variance</returns>	
        public static decimal Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			/*
			 * The variance is equal to the mean of the square minus the square of the mean:
			 *   Var(X) = E[X2] - E[X]2
			 * For example, if we consider the numbers 1, 2, 3, 4 then the mean of the squares is:
			 * 	 (1 × 1 + 2 × 2 + 3 × 3 + 4 × 4) / 4 = 7.5. 
			 * The regular mean of all four numbers is 2.5, so the square of the mean is 6.25. 
			 * Therefore the variance is 7.5 − 6.25 = 1.25 
			 */
			decimal meanOfTheSquare = 0.0M;

        	decimal mean = 0M;
			
			int count = 0;
			
			decimal num = 0M;
			
        	foreach (var element in source)
        	{   
				num = selector(element);
				
				meanOfTheSquare += (num * num);
				
				mean += num;
				
				count++;
			}
			
			if (count == 0)
			{
				throw new InvalidOperationException ();
			}
			
			meanOfTheSquare = meanOfTheSquare / count;
			
			mean = mean / count;
			
			return meanOfTheSquare - (mean * mean);
		}		
		
		#endregion
		
		#region StdDev()
		
		/*********************************************************************************************************
		 * The Standard Deviation is square root of the Variance.
		 *********************************************************************************************************/

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The standard deviation</returns>
        /// <example>
        /// <code lang="C#">
        /// double[] numbers = new double[] {1.0, 2.0, 3.0, 4.0, 5.0};
        /// double theStdDev = numbers.StdDev();
        /// </code>
        /// </example>
		public static double StdDev(this IEnumerable<int> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return Math.Sqrt(source.Variance());
		}


        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="selector">The selector.</param>
        /// <returns>The standard deviation</returns>
		public static double StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return Math.Sqrt(source.Variance(selector));
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The standard deviation</returns>
        public static double StdDev(this IEnumerable<long> source)
		{
			return Math.Sqrt(source.Variance());
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The standard deviation</returns>
        public static double StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return Math.Sqrt(source.Variance(selector));
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The standard deviation</returns>
        public static double StdDev(this IEnumerable<double> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return Math.Sqrt(source.Variance());
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The standard deviation</returns>
        public static double StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return Math.Sqrt(source.Variance(selector));
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The standard deviation</returns>
        public static float StdDev(this IEnumerable<float> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return (float)Math.Round(Math.Sqrt(source.Variance()), 7);
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The standard deviation</returns>
        public static float StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return (float)Math.Round(Math.Sqrt((double)source.Variance(selector)), 7);
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>The standard deviation</returns>
        public static decimal StdDev(this IEnumerable<decimal> source)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return (decimal)Math.Sqrt((double)source.Variance());
		}

        /// <summary>
        /// Computes the statistical standard deviation
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="selector"></param>
        /// <returns>The standard deviation</returns>
        public static decimal StdDev<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
		{
			if (source == null)
				throw new ArgumentNullException(nameof(source));
			
			return (decimal)Math.Sqrt((double)source.Variance(selector));
		}
		
		#endregion
	}//end class
}//end namespace

