# \<exception\>

## 语法 Syntax
``` csharp
<exception cref="member">description</exception>  
```

## 参数 Parameters
* cref = "member"
  对当前编译环境中出现的一个异常的引用。 编译器检查是否存在给定的异常，并将 member 转换为输出 XML 中的规范的元素名称。 member 必须出现在双引号 (" ") 内。
有关如何设置 member 格式以引用泛型类型的详细信息，请参阅处理 XML 文件。
* description
  异常的说明。

## 备注 Remarks
\<exception\> 标记让你指定可引发的异常。 此标记可应用于方法、属性、事件和索引器的定义。

## 示例 Example

``` csharp
// compile with: -doc:DocFileName.xml 

/// Comment for class
public class EClass : System.Exception
{
    // class definition...
}

/// Comment for class
class TestClass
{
    /// <exception cref="System.Exception">Thrown when...</exception>
    public void DoSomething()
    {
        try
        {
        }
        catch (EClass)
        {
        }
    }
}
```



