@echo off
set /p message="Enter Commit Message: "
git pull
git add --all
git commit -m " %message% "
git push
pause