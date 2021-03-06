//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState);
        
        string EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/gameOfLife", ReplyAction="http://tempuri.org/IService/gameOfLifeResponse")]
        void gameOfLife(ref int[] arr, int numOfThreads, ref System.DateTime time1, ref System.DateTime time2);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/gameOfLife", ReplyAction="http://tempuri.org/IService/gameOfLifeResponse")]
        System.IAsyncResult BegingameOfLife(ref int[] arr, int numOfThreads, ref System.DateTime time1, ref System.DateTime time2, System.AsyncCallback callback, object asyncState);
        
        void EndgameOfLife(ref int[] arr, ref System.DateTime time1, ref System.DateTime time2, System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientApp.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class gameOfLifeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public gameOfLifeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int[] arr {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int[])(this.results[0]));
            }
        }
        
        public System.DateTime time1 {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[1]));
            }
        }
        
        public System.DateTime time2 {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[2]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientApp.ServiceReference.IService>, ClientApp.ServiceReference.IService {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBegingameOfLifeDelegate;
        
        private EndOperationDelegate onEndgameOfLifeDelegate;
        
        private System.Threading.SendOrPostCallback ongameOfLifeCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<gameOfLifeCompletedEventArgs> gameOfLifeCompleted;
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginGetData(value, callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            string retVal = this.EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync(int value) {
            this.GetDataAsync(value, null);
        }
        
        public void GetDataAsync(int value, object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, new object[] {
                        value}, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        public void gameOfLife(ref int[] arr, int numOfThreads, ref System.DateTime time1, ref System.DateTime time2) {
            base.Channel.gameOfLife(ref arr, numOfThreads, ref time1, ref time2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingameOfLife(ref int[] arr, int numOfThreads, ref System.DateTime time1, ref System.DateTime time2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingameOfLife(ref arr, numOfThreads, ref time1, ref time2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndgameOfLife(ref int[] arr, ref System.DateTime time1, ref System.DateTime time2, System.IAsyncResult result) {
            base.Channel.EndgameOfLife(ref arr, ref time1, ref time2, result);
        }
        
        private System.IAsyncResult OnBegingameOfLife(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int[] arr = ((int[])(inValues[0]));
            int numOfThreads = ((int)(inValues[1]));
            System.DateTime time1 = ((System.DateTime)(inValues[2]));
            System.DateTime time2 = ((System.DateTime)(inValues[3]));
            return this.BegingameOfLife(ref arr, numOfThreads, ref time1, ref time2, callback, asyncState);
        }
        
        private object[] OnEndgameOfLife(System.IAsyncResult result) {
            int[] arr = this.GetDefaultValueForInitialization<int[]>();
            System.DateTime time1 = this.GetDefaultValueForInitialization<System.DateTime>();
            System.DateTime time2 = this.GetDefaultValueForInitialization<System.DateTime>();
            this.EndgameOfLife(ref arr, ref time1, ref time2, result);
            return new object[] {
                    arr,
                    time1,
                    time2};
        }
        
        private void OngameOfLifeCompleted(object state) {
            if ((this.gameOfLifeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.gameOfLifeCompleted(this, new gameOfLifeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void gameOfLifeAsync(int[] arr, int numOfThreads, System.DateTime time1, System.DateTime time2) {
            this.gameOfLifeAsync(arr, numOfThreads, time1, time2, null);
        }
        
        public void gameOfLifeAsync(int[] arr, int numOfThreads, System.DateTime time1, System.DateTime time2, object userState) {
            if ((this.onBegingameOfLifeDelegate == null)) {
                this.onBegingameOfLifeDelegate = new BeginOperationDelegate(this.OnBegingameOfLife);
            }
            if ((this.onEndgameOfLifeDelegate == null)) {
                this.onEndgameOfLifeDelegate = new EndOperationDelegate(this.OnEndgameOfLife);
            }
            if ((this.ongameOfLifeCompletedDelegate == null)) {
                this.ongameOfLifeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngameOfLifeCompleted);
            }
            base.InvokeAsync(this.onBegingameOfLifeDelegate, new object[] {
                        arr,
                        numOfThreads,
                        time1,
                        time2}, this.onEndgameOfLifeDelegate, this.ongameOfLifeCompletedDelegate, userState);
        }
    }
}
