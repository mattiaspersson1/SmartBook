package com.alvalabs.lookup.dto;

import com.fasterxml.jackson.annotation.JsonProperty;

public class PersonalDetails {

    private String address;

    @JsonProperty("first_name")
    private String firstName;

    @JsonProperty("last_name")
    private String lastName;

    public String getAddress() { return address; }
    public String getFirstName() { return firstName; }
    public String getLastName() { return lastName; }
}