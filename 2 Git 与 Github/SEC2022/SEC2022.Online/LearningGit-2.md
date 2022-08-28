# Learning Git 2 【Branch】

## 0 默认分支

![主分支](img/1.png)

## 1 新建本地分支并切换分支

首先，我们创建一个用于临时开发的分支dev,并切换到dev分支

``` shell
git checkout -b dev #checkout 检出
```
git checkout命令加上-b参数表示创建并切换，相当于以下两条命令

``` shell
git branch dev
git checkout dev
```

查看分支情况，列出所有的分支，当前分支前面会标记一个"*"号
``` shell
git branch
```

![新建分支并切换分支](img/2.png)


## 2 向新分支添加新文件并提交

在dev分支上正常提交，例如，新增一个dev-branch.md文件，然后提交并推送到远程仓库

``` shell
git add .
git commit -m "dev branch test"
git push --set-upstream origin dev

```


![在开发分支上添加新文件](img/3.png)


## 3 切换为主分支

现在，dev分支的工作完成，切换回master分支

``` shell

git checkout master
```

切换回master分支后，刚才新增的dev-branch.md文件不存在了。这是因为刚才新建dev-branch.md文件的提交是在dev分支，而master分支刺客的提交点并未发生变化。

![切换到主分支](img/4.png)

## 4 合并分支

现在，我们把dev branch分支的工作成果合并到master分支上

``` shell
git merge dev
```

git merge命令用于合并分支到当前分支。合并前，dev-branch.md文件不存在，合并后，dev-branch.md出现，文件内容与dev分支的最新提交是完全一致的。


![合并分支](img/5.png)

注意到Fast-forward提示信息，git告诉我们，这次合并是"快进模式",也就是把master指向dev的当前提交，所以合并速度非常快。

## 5 删除分支

合并完成之后，就可以放心地删除dev分支

删除本地dev分支

```
git branch -d dev
```

``` shell
git branch #查看本地分支情况
git branch -a # 查看所有分支情况（包括远程分支）

```

![删除分支](img/6.png)

```
git push origin --delete dev

```