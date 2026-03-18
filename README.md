# APBD Git Exercise

This project is a simple Student Grade Analyzer.

It demonstrates Git history, branches, merge, rebase, and conflict resolution.

## Why was this merge not fast-forward?

This merge was not fast-forward because both `main` and `feature-max` had new commits after the branch was created. Git had to create a merge commit to combine both histories.

This project also demonstrates rebasing.

## How was the conflict resolved in your repository?

The conflict was resolved by manually editing the conflicting line in `Program.cs`. Two different versions of the same output message were created on `main` and `feature-conflict`. After the merge conflict appeared, the final message was chosen manually, the conflict markers were removed, and the merge was completed with a new commit.