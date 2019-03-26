# MyCiCdTest
![CircleCI branch](https://img.shields.io/circleci/project/github/Mathavana/MyCiCdTest/master.svg?style=popout)
[![codecov](https://codecov.io/gh/Mathavana/MyCiCdTest/branch/master/graph/badge.svg)](https://codecov.io/gh/Mathavana/MyCiCdTest)
![Docker Cloud Automated build](https://img.shields.io/docker/cloud/automated/math08avan/aspnetcore-my-ci-cd-test.svg?style=popout)

Example Circleci configuration

## PR Steps
- build-status branch created for raise PR
- repo owner verify the build staus resut from Circlci, Docker
- if anything goes wrong, notify the PR onwer
- if everything Ok, Merge from build-status to develop
- Create new PR from develop to master branch
- Repo owner approve PR and release it
