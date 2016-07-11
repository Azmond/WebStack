/// <reference path="typings/jquery/jquery.d.ts" />
var StringStack = (function () {
    function StringStack() {
        this.result = new JsonResult();
        this.data = $('#textdata');
    }
    StringStack.prototype.pushStack = function () {
        var _this = this;
        $.post('/api/push', { data: this.data.val() }).done(function (d) {
            if (d.success == true) {
                _this.successMessage("Данные добавлены в стек!");
                _this.data.val("");
            }
            else
                _this.errorMessage("Ошибка добавления данных!");
        });
    };
    StringStack.prototype.popStack = function () {
        var _this = this;
        $.post('/api/pop').done(function (d) {
            if (d.success == true) {
                _this.data.val(d.data);
                _this.successMessage("Из стека было получено значение: " + d.data);
            }
            else
                _this.errorMessage("Не удалось получить значение стека!");
        });
    };
    StringStack.prototype.peekStack = function () {
        var _this = this;
        $.post('/api/peek').done(function (d) {
            if (d.success == true) {
                _this.data.val(d.data);
                _this.successMessage("В стеке находится значение: " + d.data);
            }
            else
                _this.errorMessage("Не удалось просмотреть значение стека!");
        });
    };
    StringStack.prototype.sizeStack = function () {
        var _this = this;
        $.post('/api/size').done(function (d) {
            if (d.success == true)
                _this.successMessage("Размер стека в настоящий момент: " + d.data);
            else
                _this.errorMessage("Не удалось получить размер стека!");
        });
    };
    StringStack.prototype.errorMessage = function (msg) {
        var component = $('#alertmsg');
        component.removeClass('alert-success').removeClass('hidden').addClass('alert-danger');
        component.html(msg);
    };
    StringStack.prototype.successMessage = function (msg) {
        var component = $('#alertmsg');
        component.removeClass('alert-danger').removeClass('hidden').addClass('alert-success');
        component.html(msg);
    };
    return StringStack;
}());
var JsonResult = (function () {
    function JsonResult() {
    }
    return JsonResult;
}());
window.onload = function () {
    var stack = new StringStack();
    $('#pushbtn').click(function () { stack.pushStack(); });
    $('#popbtn').click(function () { stack.popStack(); });
    $('#peekbtn').click(function () { stack.peekStack(); });
    $('#sizebtn').click(function () { stack.sizeStack(); });
};
//# sourceMappingURL=stackajax.js.map