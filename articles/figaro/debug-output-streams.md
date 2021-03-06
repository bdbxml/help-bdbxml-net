---
uid: debug-output-streams.md
---

# Debug Output Streams

The @Figaro.LogConfiguration class provides two static methods - @Figaro.LogConfiguration.SetCategory and @Figaro.LogConfiguration.SetLogLevel - that can be used to configure log output and output verbosity for the underlying Berkeley DB subsystems. You can configure output to come from the container, dictionary, indexer, node store, query optimizer, @Figaro.XmlManager, or all of the subsystems.


The output generated by the Figaro.LogConfiguration class is flushed to the **stderr** stream, which may go detected by utility applications such as **DebugView** or standard console output. To see this output, your application will have to capture **stderr** output.


## See Also

* @Figaro.XmlManager
* @Figaro.LogConfiguration


#### Other Resources
@exception-handling-and-debugging.md
