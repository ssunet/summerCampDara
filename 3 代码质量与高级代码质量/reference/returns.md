# \<returns\>

## 语法 Syntax
``` csharp
<returns>description</returns>  
```

## 参数 Parameters
* description
  返回值的说明。

## 备注 Remarks
在方法声明的注释中应使用 \<returns\> 标记来描述返回值。

## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

/// text for class TestClass
public class TestClass
{
    /// <returns>Returns zero.</returns>
    public static int GetZero()
    {
        return 0;
    }

    /// text for Main
    static void Main()
    {
    }
}
```