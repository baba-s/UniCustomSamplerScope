using System;
using UnityEngine.Profiling;

namespace UniCustomSamplerScope
{
	/// <summary>
	/// CustomSampler を using で使用できるようにするクラス
	/// </summary>
	public sealed class CustomSamplerScope : IDisposable
	{
		//================================================================================
		// 変数（readonly）
		//================================================================================
		private readonly CustomSampler m_sampler;
		
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// CustomSampler を生成してサンプリングを開始します
		/// </summary>
		public CustomSamplerScope( string name )
		{
			m_sampler = CustomSampler.Create( name ); 
			m_sampler.Begin();
		}
		
		/// <summary>
		/// CustomSampler を生成してサンプリングを開始します
		/// </summary>
		public CustomSamplerScope( string name, UnityEngine.Object targetObject )
		{
			m_sampler = CustomSampler.Create( name );
			m_sampler.Begin( targetObject );
		}
		
		/// <summary>
		/// サンプリングを終了します
		/// </summary>
		public void Dispose()
		{
			m_sampler.End();
		}
	}
}