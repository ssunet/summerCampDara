# Learning Git 2 【Branch】

## 0 默认分支

![主分支](img/1.png)

## 1 新建本地分支并切换分支

首先，我们创建dev分支，然后切换到dev分支：

``` shell
git checkout -b dev #checkout 检出
``` 

git checkout命令加上-b参数表示创建并切换，相当于以下两条命令：

``` shell
git branch dev
git checkout dev
```

![新建分支并切换分支](img/2.png)


## 2 向新分支添加新文件并提交

然后，用git branch命令查看当前分支。git branch命令会列出所有分支，当前分支前面会标一个*号。
``` shell
git branch
```

然后，我们就可以在dev分支上正常提交，比如增加一个文件。

然后提交：
``` shell
git add *.*
git commit -m "branch test"
git push --set-upstream origin dev
```

![在开发分支上添加新文件](img/3.png)


## 3 切换为主分支

现在，dev分支的工作完成，我们就可以切换回master分支：
``` shell
git checkout master
```

切换回master分支后，再查看一个README.md文件，刚才添加的内容不见了！因为那个提交是在dev分支上，而master分支此刻的提交点并没有变：

![切换为主分支](img/4.png)

## 4 合并分支

现在，我们把branch分支的工作成果合并到master分支上：

``` shell
git merge dev
```
git merge命令用于合并指定分支到当前分支。合并后，再查看readme.txt的内容，就可以看到，和dev分支的最新提交是完全一样的。

![合并分支](img/5.png)

注意到上面的Fast-forward信息，Git告诉我们，这次合并是“快进模式”，也就是直接把master指向dev的当前提交，所以合并速度非常快。

当然，也不是每次合并都能Fast-forward，我们后面会讲其他方式的合并。

## 5 删除分支

合并完成后，就可以放心地删除dev分支了：

删除本地分支

``` shell
git branch -d dev
```
删除后，查看branch，就只剩下master分支了：


![删除分支](img/6.png)

``` shell
git branch    #查看本地分支
git branch -a #查看所有分支（包含远程分支）
```
因为创建、合并和删除分支非常快，所以Git鼓励你使用分支完成某个任务，合并后再删掉分支，这和直接在master分支上工作效果是一样的，但过程更安全。

删除远程分支

``` shell
git push origin --delete dev 
```