# \<typeparam\>
## 语法 Syntax
``` csharp
<typeparam name="name">description</typeparam>  
```

## 参数 Parameters
* name
  类型参数的名称。 用双引号 (" ") 将名称引起来。
* description
  类型参数的说明。

## 备注 Remarks
在泛型类型或方法声明的注释中，应使用 \<typeparam\> 标记来描述类型参数。 为泛型类型或方法的每个类型参数添加标记。
有关详细信息，请参阅泛型。
\<typeparam\> 标记的文本将显示在 IntelliSense、对象浏览器窗口代码注释 Web 报表。

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