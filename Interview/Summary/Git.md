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

git rebase -i <commits scope>


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

