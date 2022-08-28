# \<typeparamref\>
## 语法 Syntax
``` csharp
<typeparamref name="name"/>  
```

## 参数 Parameters
* name
  类型参数的名称。 用双引号 (" ") 将名称引起来。

## 备注 Remarks
有关泛型类型中的类型参数及方法的详细信息，请参阅泛型。
通过此标记，文档文件的使用者可显著设置字体格式，例如采用斜体。


## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// comment for class
public class TestClass
{
    /// <summary>
    /// Creates a new array of arbitrary type <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The element type of the array</typeparam>
    public static T[] mkArray<T>(int n)
    {
        return new T[n];
    }
}
```