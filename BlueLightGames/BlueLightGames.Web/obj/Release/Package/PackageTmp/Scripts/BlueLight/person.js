function searchPerson() {
    var search = $("#searchString").val();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        $("#personId").val(data.PersonId);
        $("#firstName").val(data.FirstName);
        $("#lastName").val(data.LastName);
        $("#email").val(data.Email);
        $("#email").val(data.Email);
    });
}

function updatePerson() {
    var personId = $("#personID").val();
    var firstName = $("#firstName").val();
    var lastName = $("#lastName").val();
    var dateCreated = $("#dateCreated").val();
    var email = $("#email").val();

    $.ajax({
        url: "UpdatePerson",
        dataType: "json",
        data: {
            PersonId: personId,
            FirstName: firstName,
            LastName: lastName,
            DateCreated: dateCreated,
            Email: email
        }
    }).done(function (data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    });
}