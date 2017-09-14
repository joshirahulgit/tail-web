import { TailPage } from './app.po';

describe('tail App', () => {
  let page: TailPage;

  beforeEach(() => {
    page = new TailPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
