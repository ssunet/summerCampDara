# \<c\>

## 语法 Syntax

``` csharp
<c>text</c>
```  

## 参数 Parameters
* text
  要指示为代码的文本。

## 备注 Remarks
使用 \<c\> 标记可以指示应将说明内的文本标记为代码。 若指示多行为本为代码，则需要使用 [\<code\>](code.md) 。

## 示例 Example

``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    /// <summary><c>DoWork</c> is a method in the <c>TestClass</c> class.
    /// </summary>
    public static void DoWork(int Int1)
    {
    }

    /// text for Main
    static void Main()
    {
    }
}
```


