# ProgRunner

GUI program to run multiple console windows and show output.

To add new programs, add them into `app.config` as in:

```
<configuration>
  <!-- etc -->
  <custom>
    <startupProcesses>
      <processes>
        <process name="test dotnet" file="dotnet" />
        <process name="dotnet version" file="dotnet" args="-v" />
      </processes>
    </startupProcesses>
  </custom>
</configuration>
```
