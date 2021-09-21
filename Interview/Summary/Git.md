# Git

```<language>
Git commit

Git checkout <branch>

git merge <branch>
```


## Branch
```<language>
git rebase <branch>
```

**git rebase VS git merge** difference

git rebase (on) target branch

git rebase commit1 commit2

git rebase: copy and directly on the curr branch
git merge: inherite two branch and generate a new node(commit)

git merge still has another parent

## move on trees

HEAD -> current node concept

detach current node with current branch

git checkout commit<if you know the hash value>


~n -> go back n steps

git checkout Head~4

强制修改分支位置

git branch -f main HEAD~3

git revert <commit>

git reset <commit>


## edit commit tree

git cherry-pick <COMMIT1 HASH> <COMMIT2 HASH>
git 
git rebase -i <commits scope>


## edit commit tree II

$ git rebase -i HEAD~2
$ git commit --amend
$ git rebase -i HEAD~2
$ git rebase caption main


## edit commit tree III

$ git rebase -i HEAD~2
$ git commit --amend
$ git rebase -i HEAD~2
$ git rebase caption main

## git tag

git tag <info> commit
git tag v1 C1

if no commit declared, then it will be the current HEAD

## git describe

git describe 的​​语法是：

git describe <ref>

<ref> 可以是任何能被 Git 识别成提交记录的引用，如果你没有指定的话，Git 会以你目前所检出的位置（HEAD）。

它输出的结果是这样的：

<tag>_<numCommits>_g<hash>

tag 表示的是离 ref 最近的标签， numCommits 是表示这个 ref 与 tag 相差有多少个提交记录， hash 表示的是你所给定的 ref 所表示的提交记录哈希值的前几位。

当 ref 提交记录上有某个标签时，则只输出标签名称


## muliple rebase

git rebase <source> <target>


## ^(number) VS ~(number)

操作符 ^ 与 ~ 符一样，后面也可以跟一个数字。

但是该操作符后面的数字与 ~ 后面的不同，并不是用来指定向上返回几代，而是指定合并提交记录的某个父提交。还记得前面提到过的一个合并提交有两个父提交吧，所以遇到这样的节点时该选择哪条路径就不是很清晰了。

Git 默认选择合并提交的“第一个”父提交，在操作符 ^ 后跟一个数字可以改变这一默认行为。



# remote operation

## git fetch
远程分支 
远程仓库

git fetch update 远程分支 o/main，not update main


## git pull
git pull = git fetch + git merge

git --rebase 
git pull


## Pull reject

Remote Rejected!
If you work on a large collaborative team its likely that main is locked and requires some Pull Request process to merge changes. If you commit directly to main locally and try pushing you will be greeted with a message similar to this:

! [remote rejected] main -> main (TF402455: Pushes to this branch are not permitted; you must use a pull request to update this branch.)


## remote tracking


## git push
git push <remote> <place>

git push origin main

git push origin <source>:<destination>

source 可以是任何 Git 能识别的位置

## git fetch

git fetch <remote> <place>

git fetch origin foo

## git fetch/push without source.

git push origin :foo -> delete remote branch

git fetch origin :bar -> create remote branch

## git pull

git pull origin foo = git fetch origin foo; git merge o/foo


git pull origin bar~1:bugFix = git fetch origin bar~1:bugFix; git merge bugFix

看到了? git pull 实际上就是 fetch + merge 的缩写, git pull 唯一关注的是提交最终合并到哪里（也就是为 git fetch 所提供的 destination 参数）


