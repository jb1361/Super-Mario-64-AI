@echo off
git pull
set /p message="Enter Commit Message: "

git add --all
git commit -m " %message% "
git push
pause