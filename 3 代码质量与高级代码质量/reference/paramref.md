# \<paramref\>

## 语法 Syntax
``` csharp
<paramref name="name"/>  
```

## 参数 Parameters
* name
  要引用的参数的名称。 用双引号 (" ") 将名称引起来。

## 备注 Remarks
\<paramref\> 标记提供一种方式，用于指示 \<summary\> 或 \<remarks\> 块等代码注释中的单词引用某个参数。 可以处理 XML 文件以明显的方式设置此单词的格式，如使用粗体或斜体。

## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    /// <summary>DoWork is a method in the TestClass class.  
    /// The <paramref name="int1"/> parameter takes a number.
    /// </summary>
    public static void DoWork(int int1)
    {
    }

    /// text for Main
    static void Main()
    {
    }
}
```