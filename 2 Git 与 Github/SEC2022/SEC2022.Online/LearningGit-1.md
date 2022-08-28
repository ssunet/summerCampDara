# Learning Git 1 【Basic】

[Git Referrence](https://git-scm.com/docs)

Ctrl+` 打开终端Terminal Shell

# 设置用户名

``` shell

git config user.name "hust"
git config user.email "hust@hust.edu.cn"

```


# 创建git仓库的方式

# 方式一

## 初始化 git仓库

``` shell
git init
```

## 为git仓库增加README.md文件

``` shell
git add README.md
```

## 提交更改
``` shell
git commit -m "add readme.me"
```

## 设置远程仓库

``` shell

git remote add origin https://github.com/cosmosking/SEC2022.git

```

## 推送到远程仓库

``` shell

git push -u origin master

```

# 方式二

## 从远程仓库克隆

``` shell

git clone https://github.com/cosmosking/SEC2022.git

```

## 为git仓库增加README.md文件

``` shell

git add README.md

```

## 提交更改
``` shell

git commit -m "first commit"

```

## 推送到远程仓库


``` shell

git push -u origin master

```

---

## 回退分支

``` shell
git log
git reset --hard <version> 
```