# \<permission\>

## 语法 Syntax
``` csharp
<permission cref="member">description</permission>
```

## 参数 Parameters
* cref = " member"
  对可从当前编译环境调用的成员或字段的引用。 编译器检查是否存在给定的代码元素，并将 member 转换为输出 XML 中规范的元素名称。 成员必须出现在双引号 (" ") 内。  
  有关如何创建对泛型类型的 cref 引用的信息，请参阅 [\<see\>](see.md)。
* description
  对成员访问权限的说明。

## 备注 Remarks
使用 \<permission\> 可以记录成员访问权限 PermissionSet 类可指定对成员的访问权限。

## 示例 Example
``` csharp
// compile with: -doc:DocFileName.xml 

class TestClass
{
    /// <permission cref="System.Security.PermissionSet">Everyone can access this method.</permission>
    public static void Test()
    {
    }

    static void Main()
    {
    }
}
```