
# Reset

git reset --hard HEAD^ (回退到上一版本)

git reset --hard id号 (回退某一版本)

git checkout  --  &lt;file&gt; (删除某文件的工作区修改))

git checkout . (删除所有文件的临时工作区修改)

git reset HEAD &lt;file&gt; (将某文件的暂存区的提交 回撤到工作区)

git remote add origin git@server-name:path/repo-name.git

git remote add origin git@github.com:anarchy0316/CodePractise.git（关联远程库）

>
git push -u origin master (第一次要加上 -u 参数)

以后用 git push origin matser 就行




# Branch
git checkout -b &lt;BranchName&gt;  创建分支并切换

等于 git branch &lt;BranchName&gt;  +   git checkout &lt;Branch Name&gt; 

git branch 查看当前分支，会列出所有分支，然后在当前分支前加*号

git merge &lt;Branch Name&gt;  将指定分支合并至当前分支

git branch -d &lt;Branch Name&gt;  删除指定分支

git branch -D &lt;Branch Name&gt;  可以在分支上有未合并的提交时强行删除分支(要求大写D防止出错)

# 解决分支冲突
merge 时报出冲突后解决
git log --graph --pretty=oneline --abbrev-commit 

# 分支策略
git merge --no-ff -m "merge with no-ff" &lt;BracnhName&gt; 通过这个命令来关闭 Fast Forward  强迫在merge时输入commentzd gitlog 中留下记录
而且看起来 "--no-ff" 这个命令只要输入一次后后面都会强制执行

删除远程分支

git push origin --delete [branchname]

# Stash
git stash 将工作暂存，可以调用多次

git stash list  查看stash list

git stash pop  返回该stash并 stash list中的副本

git stash apply    git stash drop 相当于 git stash pop

git stash apply stash@{0} 当有多个stash 时指定回到哪一个


# 远程工作
git push origin master

git push origin dev

推送你需要推送的分支，其他分支可以放在本地

# 多人协作

远程仓库默认是 origin

查看远程库信息 git remote

或者用 git remote -v 显示更详细的信息

当他人从远程库clone时 默认情况下，只能看到本地master分支，如果想要在dev上开发，必须创建远程origin的dev分支到本地

git checkout -b dev origin/dev 

修改提交后，它就可以用 
git push origin dev
来push到远程

如果说不巧两人对同一文件做了修改，我push时提示有冲突，那么我先用 git pull 把最新的提交从 origin/dev 拉取，然后于本地合并解决冲突，再推送

git pull

如果git pull 也失败了，原因是本地  dev  分支没有和远程  origin/dev  分支建立链接

git branch --set-upstream-to=origin/dev dev

git branch --set-upstream-to &lt;branch-name&gt; origin/&lt;branch-name&gt;

再 git pull
然后动手解决冲突 提交 上传

添加vscode测试