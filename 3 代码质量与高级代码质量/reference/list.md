# \<list\>

## 语法 Syntax
``` csharp
<list type="bullet" | "number" | "table"> 
    <listheader>  
        <term>term</term>  
        <description>description</description>  
    </listheader>  
    <item>  
        <term>term</term>  
        <description>description</description>  
    </item>  
</list>  
```

## 参数 Parameters
* term
  要定义的术语，将在 description 中进行定义。
* description
  项目符号或编号列表中的项或 term 的定义。

## 备注 Remarks
\<listheader\> 块用于定义表或定义列表的标题行。 定义表时，只需提供标题中的术语的项。
列表中的每个项均使用 \<item\> 块指定。 创建定义列表时，需要同时指定 term 和 description。 但是，对于表、项目符号列表或编号列表，只需提供 description 的项。
列表或表可根据需要具有多个 \<item\> 块。


## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    /// <summary>Here is an example of a bulleted list:
    /// <list type="bullet">
    /// <item>
    /// <description>Item 1.</description>
    /// </item>
    /// <item>
    /// <description>Item 2.</description>
    /// </item>
    /// </list>
    /// </summary>
    static void Main()
    {
    }
}
```