# Readme

## Git Config

In order to resolve carriage return issues like this:
```
fatal: CRLF would be replaced by LF in <someFile>

fatal: LF would be replaced by CRLF in <someFile>

```

You may want to set these git configurations

```
git config core.autocrlf true
git config core.safecrlf false
```
