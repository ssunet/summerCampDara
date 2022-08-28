# \<include\>

## 语法 Syntax
``` csharp
<include file='filename' path='tagpath[@name="id"]' />  
```  

## 参数 Parameters
* filename
  包含文档的 XML 文件的名称。 可使用相对于源代码文件的路径限定文件名。 使用单引号 (' ') 将 filename 括起来。
* tagpath
  filename 中标记的路径，它指向标记 name。 使用单引号 (' ') 将路径括起来。
* name
  标记中的名称说明符（位于注释之前）；name 将有 id。
* id
  标记的 ID（位于注释之前）。 用双引号 (" ") 将 ID 括起来。

## 备注 Remarks
通过 \<include\> 标记，可在其他文件中引用描述源代码中类型和成员的注释。 这是对直接在源代码文件中放入文档注释的替代方法。 通过将文档放入不同文件，可以单独从源代码对文档应用源控件。 一人可以签出源代码文件，而其他人可以签出文档文件。
\<include\> 标记使用 XML XPath 语法。 有关如何自定义 \<include\> 的用法，请参阅 [XPath](https://www.w3school.com.cn/xpath/xpath_syntax.asp) 文档。

## 示例 Example
这是多文件示例。 第一个文件使用 <include>，列在下面：
``` csharp
// compile with: -doc:DocFileName.xml 

/// <include file='xml_include_tag.doc' path='MyDocs/MyMembers[@name="test"]/*' />
class Test
{
    static void Main()
    {
    }
}

/// <include file='xml_include_tag.doc' path='MyDocs/MyMembers[@name="test2"]/*' />
class Test2
{
    public void Test()
    {
    }
}
```

第二个文件是 xml_include_tag.doc，包含下列文档注释：
``` xml
<MyDocs>  
<MyMembers name="test">  
<summary>  
The summary for this type.  
</summary>  
</MyMembers>  
<MyMembers name="test2">  
<summary>  
The summary for this other type.  
</summary>  
</MyMembers>  
</MyDocs>  
```