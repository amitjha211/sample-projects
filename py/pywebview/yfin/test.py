import webview

class Api:
    def say_hello(self, name):
        # This python function can be called from JavaScript
        sMessage = f"Hello {name} from the Python backend!!"
        return sMessage
    def json_test(self):
        return { "firstName" : "amit","lastName" :"jha" }

api = Api()

# Expose the API class instance via the 'js_api' parameter
webview.create_window('Bridge App', 'index.html', js_api=api)
webview.start(http_server=True,debug=True)
