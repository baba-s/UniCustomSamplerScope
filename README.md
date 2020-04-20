# Uni Custom Sampler Scope

UnityEngine.Profiling.CustomSampler を using で使用できるようにするクラス

## 使用例

```cs
using ( new CustomSamplerScope( "【Profiler における表示名】" ) )
{
}

using ( new CustomSamplerScope( "【Profiler における表示名】", gameObject ) )
{
}
```