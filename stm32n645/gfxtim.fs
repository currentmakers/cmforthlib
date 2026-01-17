\
\ @file gfxtim.fs
\ @brief Graphic timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GFXTIM_DEF

  [ifdef] GFXTIM_GFXTIM_CR_DEF
    \
    \ @brief GFXTIM configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_TES                     \ [0x00 : 2] tearing source
    $04 constant GFXTIM_TEPOL                   \ [0x04] tearing--effect polarity
    $08 constant GFXTIM_SYNCS                   \ [0x08 : 2] synchronization source
    $10 constant GFXTIM_FCCOE                   \ [0x10] frame-clock calibration output enable
    $11 constant GFXTIM_LCCOE                   \ [0x11] line-clock calibration output enable
  [then]


  [ifdef] GFXTIM_GFXTIM_CGCR_DEF
    \
    \ @brief GFXTIM clock generator configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LCS                     \ [0x00 : 3] line clock source
    $04 constant GFXTIM_LCCCS                   \ [0x04] line clock counter clock source
    $08 constant GFXTIM_LCCFR                   \ [0x08] line clock counter force reload
    $0c constant GFXTIM_LCCHRS                  \ [0x0c : 3] line clock counter hardware reload source
    $10 constant GFXTIM_FCS                     \ [0x10 : 3] frame clock source
    $14 constant GFXTIM_FCCCS                   \ [0x14 : 3] frame clock counter clock source
    $18 constant GFXTIM_FCCFR                   \ [0x18] frame clock counter force reload
    $1c constant GFXTIM_FCCHRS                  \ [0x1c : 3] frame- -clock counter hardware reload source
  [then]


  [ifdef] GFXTIM_GFXTIM_TCR_DEF
    \
    \ @brief GFXTIM timers configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCEN                   \ [0x00] absolute frame counter enable
    $01 constant GFXTIM_FAFCR                   \ [0x01] force absolute frame counter reset
    $04 constant GFXTIM_ALCEN                   \ [0x04] absolute line counter enable
    $05 constant GFXTIM_FALCR                   \ [0x05] force absolute line counter reset
    $10 constant GFXTIM_RFC1EN                  \ [0x10] relative frame counter 1 enable
    $11 constant GFXTIM_RFC1CM                  \ [0x11] relative frame counter 1 continuous mode
    $12 constant GFXTIM_FRFC1R                  \ [0x12] force relative frame counter 1 reload
    $14 constant GFXTIM_RFC2EN                  \ [0x14] relative frame counter 2 enable
    $15 constant GFXTIM_RFC2CM                  \ [0x15] relative frame counter 2 continuous mode
    $16 constant GFXTIM_FRFC2R                  \ [0x16] force relative frame counter 2 reload
  [then]


  [ifdef] GFXTIM_GFXTIM_TDR_DEF
    \
    \ @brief GFXTIM timers disable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCDIS                  \ [0x00] absolute frame counter disable
    $04 constant GFXTIM_ALCDIS                  \ [0x04] absolute line counter disable
    $10 constant GFXTIM_RFC1DIS                 \ [0x10] relative frame counter 1 disable
    $14 constant GFXTIM_RFC2DIS                 \ [0x14] relative frame counter 2 disable
  [then]


  [ifdef] GFXTIM_GFXTIM_EVCR_DEF
    \
    \ @brief GFXTIM events control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_EV1EN                   \ [0x00] event 1 enable
    $01 constant GFXTIM_EV2EN                   \ [0x01] event 2 enable
    $02 constant GFXTIM_EV3EN                   \ [0x02] event 3 enable
    $03 constant GFXTIM_EV4EN                   \ [0x03] event 4 enable
  [then]


  [ifdef] GFXTIM_GFXTIM_EVSR_DEF
    \
    \ @brief GFXTIM events selection register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LES1                    \ [0x00 : 3] line-event selection 1
    $04 constant GFXTIM_FES1                    \ [0x04 : 3] frame-event selection 1
    $08 constant GFXTIM_LES2                    \ [0x08 : 3] line-event selection 2
    $0c constant GFXTIM_FES2                    \ [0x0c : 3] frame-event selection 2
    $10 constant GFXTIM_LES3                    \ [0x10 : 3] line-event selection 3
    $14 constant GFXTIM_FES3                    \ [0x14 : 3] frame-event selection 3
    $18 constant GFXTIM_LES4                    \ [0x18 : 3] line-event selection 4
    $1c constant GFXTIM_FES4                    \ [0x1c : 3] frame-event selection 4
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGTCR_DEF
    \
    \ @brief GFXTIM watchdog timer configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_WDGEN                   \ [0x00] watchdog enable
    $01 constant GFXTIM_WDGDIS                  \ [0x01] watchdog disable
    $02 constant GFXTIM_WDGS                    \ [0x02] watchdog status
    $04 constant GFXTIM_WDGHRC                  \ [0x04 : 2] watchdog hardware reload configuration
    $08 constant GFXTIM_WDGCS                   \ [0x08 : 4] watchdog clock source
    $10 constant GFXTIM_FWDGR                   \ [0x10] force watchdog reload
  [then]


  [ifdef] GFXTIM_GFXTIM_ISR_DEF
    \
    \ @brief GFXTIM interrupt status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCOF                   \ [0x00] absolute frame counter overflow flag
    $01 constant GFXTIM_ALCOF                   \ [0x01] absolute line counter overflow flag
    $02 constant GFXTIM_TEF                     \ [0x02] tearing-effect flag
    $04 constant GFXTIM_AFCC1F                  \ [0x04] absolute frame counter compare 1 flag
    $08 constant GFXTIM_ALCC1F                  \ [0x08] absolute line counter compare 1 flag
    $09 constant GFXTIM_ALCC2F                  \ [0x09] absolute line counter compare 2 flag
    $0c constant GFXTIM_RFC1RF                  \ [0x0c] relative frame counter 1 reload flag
    $0d constant GFXTIM_RFC2RF                  \ [0x0d] relative frame counter 2 reload flag
    $10 constant GFXTIM_EV1F                    \ [0x10] event 1 flag
    $11 constant GFXTIM_EV2F                    \ [0x11] event 2 flag
    $12 constant GFXTIM_EV3F                    \ [0x12] event 3 flag
    $13 constant GFXTIM_EV4F                    \ [0x13] event 4 flag
    $18 constant GFXTIM_WDGAF                   \ [0x18] watchdog alarm flag
    $19 constant GFXTIM_WDGPF                   \ [0x19] watchdog pre-alarm flag
  [then]


  [ifdef] GFXTIM_GFXTIM_ICR_DEF
    \
    \ @brief GFXTIM interrupt clear register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_CAFCOF                  \ [0x00] clear absolute frame counter overflow flag
    $01 constant GFXTIM_CALCOF                  \ [0x01] clear absolute line counter overflow flag
    $02 constant GFXTIM_CTEF                    \ [0x02] clear tearing-effect flag
    $04 constant GFXTIM_CAFCC1F                 \ [0x04] clear absolute frame counter compare 1 flag
    $08 constant GFXTIM_CALCC1F                 \ [0x08] clear absolute line counter compare 1 flag
    $09 constant GFXTIM_CALCC2F                 \ [0x09] clear absolute line counter compare 2 flag
    $0c constant GFXTIM_CRFC1RF                 \ [0x0c] clear relative frame counter 1 reload flag
    $0d constant GFXTIM_CRFC2RF                 \ [0x0d] clear relative frame counter 2 reload flag
    $10 constant GFXTIM_CEV1F                   \ [0x10] clear event 1 flag
    $11 constant GFXTIM_CEV2F                   \ [0x11] clear event 2 flag
    $12 constant GFXTIM_CEV3F                   \ [0x12] clear event 3 flag
    $13 constant GFXTIM_CEV4F                   \ [0x13] clear event 4 flag
    $18 constant GFXTIM_CWDGAF                  \ [0x18] clear watchdog alarm flag
    $19 constant GFXTIM_CWDGPF                  \ [0x19] clear watchdog pre-alarm flag
  [then]


  [ifdef] GFXTIM_GFXTIM_IER_DEF
    \
    \ @brief GFXTIM interrupt enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCOIE                  \ [0x00] absolute frame counter overflow interrupt enable
    $01 constant GFXTIM_ALCOIE                  \ [0x01] absolute line counter overflow interrupt enable
    $02 constant GFXTIM_TEIE                    \ [0x02] tearing-effect interrupt enable
    $04 constant GFXTIM_AFCC1IE                 \ [0x04] absolute frame counter compare 1 interrupt enable
    $08 constant GFXTIM_ALCC1IE                 \ [0x08] absolute line counter compare 1 interrupt enable
    $09 constant GFXTIM_ALCC2IE                 \ [0x09] absolute line counter compare 2 interrupt enable
    $0c constant GFXTIM_RFC1RIE                 \ [0x0c] relative frame counter 1 reload interrupt enable
    $0d constant GFXTIM_RFC2RIE                 \ [0x0d] relative frame counter 2 reload interrupt enable
    $10 constant GFXTIM_EV1IE                   \ [0x10] event 1 interrupt enable
    $11 constant GFXTIM_EV2IE                   \ [0x11] event 2 interrupt enable
    $12 constant GFXTIM_EV3IE                   \ [0x12] event 3 interrupt enable
    $13 constant GFXTIM_EV4IE                   \ [0x13] event 4 interrupt enable
    $18 constant GFXTIM_WDGAIE                  \ [0x18] watchdog alarm interrupt enable
    $19 constant GFXTIM_WDGPIE                  \ [0x19] watchdog pre-alarm interrupt enable
  [then]


  [ifdef] GFXTIM_GFXTIM_TSR_DEF
    \
    \ @brief GFXTIM timers status register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_AFCS                    \ [0x00] absolute frame counter status
    $04 constant GFXTIM_ALCS                    \ [0x04] absolute line counter status
    $10 constant GFXTIM_RFC1S                   \ [0x10] relative frame counter 1 status
    $14 constant GFXTIM_RFC2S                   \ [0x14] relative frame counter 2 status
  [then]


  [ifdef] GFXTIM_GFXTIM_LCCRR_DEF
    \
    \ @brief GFXTIM line clock counter reload register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 22] reload value
  [then]


  [ifdef] GFXTIM_GFXTIM_FCCRR_DEF
    \
    \ @brief GFXTIM frame clock counter reload register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 12] reload value
  [then]


  [ifdef] GFXTIM_GFXTIM_ATR_DEF
    \
    \ @brief GFXTIM absolute time register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number
    $0c constant GFXTIM_FRAME                   \ [0x0c : 20] fame number
  [then]


  [ifdef] GFXTIM_GFXTIM_AFCR_DEF
    \
    \ @brief GFXTIM absolute frame counter register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 20] frame number
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCR_DEF
    \
    \ @brief GFXTIM absolute line counter register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number
  [then]


  [ifdef] GFXTIM_GFXTIM_AFCC1R_DEF
    \
    \ @brief GFXTIM absolute frame counter compare 1 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 20] frame number
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCC1R_DEF
    \
    \ @brief GFXTIM absolute line counter compare 1 register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number
  [then]


  [ifdef] GFXTIM_GFXTIM_ALCC2R_DEF
    \
    \ @brief GFXTIM absolute line counter compare 2 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_LINE                    \ [0x00 : 12] line number
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC1R_DEF
    \
    \ @brief GFXTIM relative frame counter 1 register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame number
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC1RR_DEF
    \
    \ @brief GFXTIM relative frame counter 1 reload register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame reload value
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC2R_DEF
    \
    \ @brief GFXTIM relative frame counter 2 register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame number
  [then]


  [ifdef] GFXTIM_GFXTIM_RFC2RR_DEF
    \
    \ @brief GFXTIM relative frame counter 2 reload register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_FRAME                   \ [0x00 : 12] frame reload value
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGCR_DEF
    \
    \ @brief GFXTIM watchdog counter register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_VALUE                   \ [0x00 : 16] value
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGRR_DEF
    \
    \ @brief GFXTIM watchdog reload register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_RELOAD                  \ [0x00 : 16] reload value
  [then]


  [ifdef] GFXTIM_GFXTIM_WDGPAR_DEF
    \
    \ @brief GFXTIM watchdog pre-alarm register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXTIM_PREALARM                \ [0x00 : 16] pre-alarm value
  [then]

  \
  \ @brief Graphic timer
  \
  $00 constant GFXTIM_GFXTIM_CR         \ GFXTIM configuration register
  $04 constant GFXTIM_GFXTIM_CGCR       \ GFXTIM clock generator configuration register
  $08 constant GFXTIM_GFXTIM_TCR        \ GFXTIM timers configuration register
  $0C constant GFXTIM_GFXTIM_TDR        \ GFXTIM timers disable register
  $10 constant GFXTIM_GFXTIM_EVCR       \ GFXTIM events control register
  $14 constant GFXTIM_GFXTIM_EVSR       \ GFXTIM events selection register
  $20 constant GFXTIM_GFXTIM_WDGTCR     \ GFXTIM watchdog timer configuration register
  $30 constant GFXTIM_GFXTIM_ISR        \ GFXTIM interrupt status register
  $34 constant GFXTIM_GFXTIM_ICR        \ GFXTIM interrupt clear register
  $38 constant GFXTIM_GFXTIM_IER        \ GFXTIM interrupt enable register
  $3C constant GFXTIM_GFXTIM_TSR        \ GFXTIM timers status register
  $40 constant GFXTIM_GFXTIM_LCCRR      \ GFXTIM line clock counter reload register
  $44 constant GFXTIM_GFXTIM_FCCRR      \ GFXTIM frame clock counter reload register
  $50 constant GFXTIM_GFXTIM_ATR        \ GFXTIM absolute time register
  $54 constant GFXTIM_GFXTIM_AFCR       \ GFXTIM absolute frame counter register
  $58 constant GFXTIM_GFXTIM_ALCR       \ GFXTIM absolute line counter register
  $60 constant GFXTIM_GFXTIM_AFCC1R     \ GFXTIM absolute frame counter compare 1 register
  $70 constant GFXTIM_GFXTIM_ALCC1R     \ GFXTIM absolute line counter compare 1 register
  $74 constant GFXTIM_GFXTIM_ALCC2R     \ GFXTIM absolute line counter compare 2 register
  $80 constant GFXTIM_GFXTIM_RFC1R      \ GFXTIM relative frame counter 1 register
  $84 constant GFXTIM_GFXTIM_RFC1RR     \ GFXTIM relative frame counter 1 reload register
  $88 constant GFXTIM_GFXTIM_RFC2R      \ GFXTIM relative frame counter 2 register
  $8C constant GFXTIM_GFXTIM_RFC2RR     \ GFXTIM relative frame counter 2 reload register
  $A0 constant GFXTIM_GFXTIM_WDGCR      \ GFXTIM watchdog counter register
  $A4 constant GFXTIM_GFXTIM_WDGRR      \ GFXTIM watchdog reload register
  $A8 constant GFXTIM_GFXTIM_WDGPAR     \ GFXTIM watchdog pre-alarm register

: GFXTIM_DEF ; [then]
