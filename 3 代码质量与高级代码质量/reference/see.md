# \<see\>

## 语法 Syntax
``` csharp
<see cref="member"/>  
```

## 参数 Parameters
* cref = "member"
对可从当前编译环境调用的成员或字段的引用。 编译器检查是否存在给定的码位元素，并将 member 传递到输出 XML 中的元素名称。 将成员置于双引号 (" ") 内。

## 备注 Remarks
通过 \<see\> 标记可以从文本内指定链接。 使用 [\<seealso\>](seealso.md) 指示文本应该放在“另请参阅”部分中。 使用 cref 属性创建指向代码元素的文档页的内部超链接。。

## 示例 Example

``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    /// <summary>DoWork is a method in the TestClass class.
    /// <para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine(System.String)"/> for information about output statements.</para>
    /// <seealso cref="TestClass.Main"/>
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