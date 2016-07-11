/// <reference path="typings/jquery/jquery.d.ts" />

class StringStack {

    private result: JsonResult = new JsonResult();
    private data = $('#textdata');


    pushStack(): void {

        $.post('/api/push', { data: this.data.val() }).done(
            (d: JsonResult) => {

                if (d.success == true) {
                    this.successMessage("Данные добавлены в стек!");
                    this.data.val("");
                }
                else
                    this.errorMessage("Ошибка добавления данных!");
            });
    }

    popStack(): void {

        $.post('/api/pop').done((d: JsonResult) => { 

        if (d.success == true) {
            this.data.val(d.data);
            this.successMessage("Из стека было получено значение: " + d.data);
        }
        else
            this.errorMessage("Не удалось получить значение стека!");
        });
    }

    peekStack(): void {

        $.post('/api/peek').done((d: JsonResult) => { 

        if (d.success == true) {
            this.data.val(d.data);
            this.successMessage("В стеке находится значение: " + d.data);
        }
        else
            this.errorMessage("Не удалось просмотреть значение стека!");
        });
    }

    sizeStack(): void {

        $.post('/api/size').done((d: JsonResult) => {

        if (d.success == true)
            this.successMessage("Размер стека в настоящий момент: " + d.data);
        else
            this.errorMessage("Не удалось получить размер стека!");
        });
    }

    errorMessage(msg: string): void {
        var component = $('#alertmsg');
        component.removeClass('alert-success').removeClass('hidden').addClass('alert-danger');
        component.html(msg);
    }

    successMessage(msg: string): void {
        var component = $('#alertmsg');
        component.removeClass('alert-danger').removeClass('hidden').addClass('alert-success');
        component.html(msg);
    }
}

class JsonResult {
    data: string;
    success: boolean;
}

window.onload = () => {
    var stack: StringStack = new StringStack();
    $('#pushbtn').click(() => { stack.pushStack(); });
    $('#popbtn').click(() => { stack.popStack(); });
    $('#peekbtn').click(() => { stack.peekStack(); });
    $('#sizebtn').click(() => { stack.sizeStack(); });
}