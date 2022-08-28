# \<param\>

## 语法 Syntax
``` csharp
<param name="name">description</param>  
```
## 参数 Parameters
* name
  方法参数的名称。 用双引号 (" ") 将名称引起来。
* description
  参数的说明。
## 备注 Remarks
在方法声明的注释中，应使用 \<param\> 标记来描述方法参数之一。 若要记录多个参数，请使用多个 \<param\> 标记。
\<param\> 标记的文本将显示在 IntelliSense、对象浏览器和代码注释 Web 报表中。

## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    // Single parameter.
    /// <param name="Int1">Used to indicate status.</param>
    public static void DoWork(int Int1)
    {
    }

    // Multiple parameters.
    /// <param name="Int1">Used to indicate status.</param>
    /// <param name="Float1">Used to specify context.</param>
    public static void DoWork(int Int1, float Float1)
    {
    }

    /// text for Main
    static void Main()
    {
    }
}

```