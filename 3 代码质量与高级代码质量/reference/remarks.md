# \<remarks\>
## 语法 Syntax
``` csharp
<remarks>description</remarks> 
```

## 参数 Parameters
* Description
  对成员的说明。

## 备注 Remarks
\<remarks\> 标记用于添加有关某个类型的信息，从而补充由 [\<summary\>](summary) 指定的信息。 此信息显示在对象浏览器窗口中。

## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// <summary>
/// You may have some primary information about this class.
/// </summary>
/// <remarks>
/// You may have some additional information about this class.
/// </remarks>
public class TestClass
{
    /// text for Main
    static void Main()
    {
    }
}
```