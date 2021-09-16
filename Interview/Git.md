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

**git rebase VS git merge**

git rebase (on) target branch

## move on trees

~ 后退多步
git checkout Head~4

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