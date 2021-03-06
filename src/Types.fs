module App.Types

open Global

type Msg =
  | HomeMsg of Home.Types.Msg
  | NavbarMsg of Navbar.Types.Msg

type Model = {
    currentPage: Page
    navbar: Navbar.Types.Model
    speakers: Speakers.Types.Model
    home: Home.Types.Model
  }
