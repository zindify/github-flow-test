# Testing the GitHub flow

This repository is a playground for the GitHub flow.

It contains a ASP.NET Core MVC 2.1 application that you can use as a target for your commits.

## Fork the repository

To start, create a fork of this repository by clicking the "Fork" button on the top-right corner.

Reference links:
- https://help.github.com/articles/fork-a-repo/
- https://help.github.com/articles/about-forks/

## Create a local clone of your fork

Once the fork is created, clone it to your computer via console or any GUI (like SourceTree). You can get the clone URL from the "Clone or Download" green button.

If you use the console, you can use this: `git clone git@github.com:YOURNAME/github-flow-test.git [FOLDER_NAME]`
- `YOURNAME` is the name of your GitHub account
- `FOLDER_NAME` is an optional parameter to name the folder used to clone your repository into

Reference links:
- https://git-scm.com/docs/git-clone

## Add a remote pointing to upstream

When you clone your fork, your origin remote will point to your fork.
To be able to properly create pull requests, you'll need to add a remote pointing to the central repository (aka upstream)

If you use the console, you can use this: `git remote add upstream git@github.com:emgdev/github-flow-test.git`

## Add a remote pointing to someone else's fork

In addition, you can add a remote pointing to the fork of someone you are collaborating with on a feature: `git remote add BUDDY git@github.com:BUDDY/github-flow-test.git`
- BUDDY is the name of your buddy GitHub account

e.g. `git remote add kralizek git@github.com:Kralizek/github-flow-test.git`

## Getting some work done

Now that the repository has been successfully forked and cloned, it's about time to get something done!

### Get the latest from upstream

Before we start, let's make sure your local clone and your fork are synced with upstream.

Reference links
- https://help.github.com/articles/syncing-a-fork/

#### Fetch changes from all remotes
You can fetch changes from all remotes by executing `git fetch --all`. Note that `-a` is not a shortening for `--all`

Reference links
- https://git-scm.com/docs/git-fetch

#### Merge the changes into your master
Once you have fetched the changes from upstream, you can merge those changes onto your master by executing `git merge upstream/master`.

In case your local master diverges from the upstream one sensibly, it's best to do an hard reset. You can do this by executing `git reset --hard upstream/master`.

#### Push to your fork
When your local master is synced with `upstream/master`, you want to push these changes to your fork's `master`. You can do this by executing `git push`. Most likely, if you had to do a hard reset, you'll need to force push: `git push -f`.

Now `master` and `origin/master` are synced with `upstream/master`.

You can apply the same concepts when syncing with the forks of other workmates. (In this case you might want to create a `master-BUDDY` branch.

Reference links
- https://git-scm.com/docs/git-push

### Create a new branch

When working with the GitHub flow, it's suggested to always create a new branch for your features. This will keep your master branch clean and ready to ingest updates from the upstream's master.

You can create a new branch by executing the command `git branch something-meaningful`. Alternatively, you can use `git checkout -b something-meaningful` to create a branch and switch into it.

Reference links
- https://git-scm.com/docs/git-branch
- https://git-scm.com/docs/git-checkout

### Sending a pull request

Once you are done hacking, you can use pull requests to let others know about the changes you pushed to your fork.

Pull requests are created via the GitHub web UI and they will automatically take all the past and future commits since your branch was created or synced with the pull request target.

While authoring a pull request, you can add comments to the thread, tag other participants and comment your commits or files of the repository down to individual lines.

Once your pull request is merged and/or closed, you should clean up your environment by deleting your work branch both locally and on your fork.

Whilst you can use the GitHub web UI to delete a branch, you can use `git branch -D BRANCH_NAME` to delete it locally. Note that `-D` means "force delete", your branch will be deleted even if your changes haven't been merged into your local master. (git is unaware of pull requests, changes merged in the upstream are still marked as "not merged" in your fork).

Reference links
- https://help.github.com/articles/about-pull-requests/
- https://git-scm.com/docs/git-branch

## Additional useful links

Here is a list of useful articles and references
- [GitHub knowledge base](https://help.github.com/): [Working with issues and pull requests](https://help.github.com/categories/collaborating-with-issues-and-pull-requests/)
- [Git flow](https://git-scm.com/about/distributed)
- GitHub flow vs Git flow
  - http://scottchacon.com/2011/08/31/github-flow.html
  - https://www.freshconsulting.com/git-development-workflows-git-flow-vs-github-flow/
  - https://lucamezzalira.com/2014/03/10/git-flow-vs-github-flow/
