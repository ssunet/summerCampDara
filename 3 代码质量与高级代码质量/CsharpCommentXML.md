# C# XML 文档注释

在 Visual C# 中，可以通过以下方式为代码创建文档：将特殊注释字段中的 XML 元素包含在源代码中注释引用的代码块的前面，例如：

``` csharp
/// <summary>  
/// This class performs an important function.  
/// </summary>  
public class MyClass {} 
```

编译时通过使用 /doc 选项，编译器会在源代码中搜索所有 XML 标记，并创建一个 XML 文档文件。基于编译器生成的文件，可以借助 [DocFX](https://dotnet.github.io/docfx/) 或 [Sandcastle](https://github.com/EWSoftware/SHFB) 等自动文档生成工具创建最终文档。

**<label style="color:red">注意：</label>**
**只能在类型和类型成员等代码构造中处理标记。不可对命名空间应用文档注释。**

以下标记为提供用户文档的中常用功能：
* [<c\>](reference/c.md)
* [\<para\>](reference/para.md)
* [\<see\>](reference/see.md)*
* [\<code\>](reference/code.md)
* [\<param\>](reference/param.md)*
* [\<seealso\>](reference/seealso.md)*
* [\<example\>](reference/example.md)
* [\<paramref\>](reference/paramref.md)
* [\<summary\>](reference/summary.md)
* [\<exception\>](reference/exception.md)*
* [\<permission\>](reference/permission.md)*
* [\<typeparam\>](reference/typeparam.md)*
* [\<include\>](reference/include.md)*
* [\<remarks\>](reference/remarks.md)
* [\<typeparamref\>](reference/typeparamref.md)
* [\<list\>](reference/list.md)
* [\<returns\>](reference/returns.md)
* [\<value\>](reference/value.md)

**（其中 \* 表示编译器需要验证语法。）**

另外，值得注意的是
如果希望在文档注释的文本中显示尖括号，请使用 \< 和 \> 的 HTML 编码，分别为 \&lt; 和 \&gt;。 下面的示例对此编码进行了演示：

**<label style="color:red">\&lt;</label>:less than** &lt;
**<label style="color:red">\&gt;</label>:great than** &gt;

``` csharp
/// <summary>
/// This property always returns a value &lt; 1.
/// </summary>
```




