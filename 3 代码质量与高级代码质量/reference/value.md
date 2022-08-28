# \<value\>
## 语法 Syntax
``` csharp
<value>property-description</value>  
```

## 参数 Parameters
* property-description
  属性的说明。

## 备注 Remarks
\<value\> 标记可以描述属性表示的值。 请注意，在 Visual Studio .NET 开发环境中通过代码向导添加属性时，将添加新属性的 [\<summary\>](summary.md) 标记。 然后，应手动添加 \<value\> 标记，描述属性表示的值。


## 示例 Example

``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class Employee
public class Employee
{
    private string _name;

    /// <summary>The Name property represents the employee's name.</summary>
    /// <value>The Name property gets/sets the value of the string field, _name.</value>

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}

/// text for class MainClass
public class MainClass
{
    /// text for Main
    static void Main()
    {
    }
}

```