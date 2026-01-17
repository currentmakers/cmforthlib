\
\ @file bsec.fs
\ @brief BSEC2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BSEC_DEF

  [ifdef] BSEC_BSEC_OTP_CONFIG_DEF
    \
    \ @brief BSEC OTP configuration register
    \ Address offset: 0x00
    \ Reset value: 0x0000000E
    \
    $00 constant BSEC_PWRUP                     \ [0x00] PWRUP
    $01 constant BSEC_FRC                       \ [0x01 : 2] FRC
    $03 constant BSEC_PRGWIDTH                  \ [0x03 : 4] PRGWIDTH
    $07 constant BSEC_TREAD                     \ [0x07 : 2] TREAD
  [then]


  [ifdef] BSEC_BSEC_OTP_CONTROL_DEF
    \
    \ @brief BSEC OTP control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ADDR                      \ [0x00 : 7] ADDR
    $08 constant BSEC_PROG                      \ [0x08] PROG
    $09 constant BSEC_LOCK                      \ [0x09] LOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_WRDATA_DEF
    \
    \ @brief BSEC OTP write data register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRDATA                    \ [0x00 : 32] WRDATA
  [then]


  [ifdef] BSEC_BSEC_OTP_STATUS_DEF
    \
    \ @brief BSEC OTP status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SECURE                    \ [0x00] SECURE
    $01 constant BSEC_FULLDBG                   \ [0x01] FULLDBG
    $02 constant BSEC_INVALID                   \ [0x02] INVALID
    $03 constant BSEC_BUSY                      \ [0x03] BUSY
    $04 constant BSEC_PROGFAIL                  \ [0x04] PROGFAIL
    $05 constant BSEC_PWRON                     \ [0x05] PWRON
    $06 constant BSEC_BIST1LOCK                 \ [0x06] BIST1LOCK
    $07 constant BSEC_BIST2LOCK                 \ [0x07] BIST2LOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_LOCK_DEF
    \
    \ @brief BSEC OTP lock configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_OTP                       \ [0x00] OTP
    $01 constant BSEC_ROMLOCK                   \ [0x01] ROMLOCK
    $02 constant BSEC_DENREG                    \ [0x02] DENREG
    $04 constant BSEC_GPLOCK                    \ [0x04] GPLOCK
  [then]


  [ifdef] BSEC_BSEC_DENABLE_DEF
    \
    \ @brief reset value depends on OTP secure mode according toTable18: BSEC_DENABLE default values after reset on page181.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DFTEN                     \ [0x00] DFTEN
    $01 constant BSEC_DBGEN                     \ [0x01] DBGEN
    $02 constant BSEC_NIDEN                     \ [0x02] NIDEN
    $03 constant BSEC_DEVICEEN                  \ [0x03] DEVICEEN
    $04 constant BSEC_HDPEN                     \ [0x04] HDPEN
    $05 constant BSEC_SPIDEN                    \ [0x05] SPIDEN
    $06 constant BSEC_SPNIDEN                   \ [0x06] SPNIDEN
    $07 constant BSEC_CP15SDISABLE              \ [0x07 : 2] CP15SDISABLE
    $09 constant BSEC_CFGSDISABLE               \ [0x09] CFGSDISABLE
    $0a constant BSEC_DBGSWENABLE               \ [0x0a] DBGSWENABLE
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED0_DEF
    \
    \ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] DIS
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED1_DEF
    \
    \ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] DIS
  [then]


  [ifdef] BSEC_BSEC_OTP_DISTURBED2_DEF
    \
    \ @brief BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DIS                       \ [0x00 : 32] DIS
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR0_DEF
    \
    \ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] ERR
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR1_DEF
    \
    \ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] ERR
  [then]


  [ifdef] BSEC_BSEC_OTP_ERROR2_DEF
    \
    \ @brief BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ERR                       \ [0x00 : 32] ERR
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK0_DEF
    \
    \ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] WRLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK1_DEF
    \
    \ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] WRLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_WRLOCK2_DEF
    \
    \ @brief BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRLOCK                    \ [0x00 : 32] WRLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK0_DEF
    \
    \ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] SPLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK1_DEF
    \
    \ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] SPLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SPLOCK2_DEF
    \
    \ @brief BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK                    \ [0x00 : 32] SPLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK0_DEF
    \
    \ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
    \ Address offset: 0x7C
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] SWLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK1_DEF
    \
    \ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
    \ Address offset: 0x80
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] SWLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SWLOCK2_DEF
    \
    \ @brief BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
    \ Address offset: 0x84
    \ Reset value: 0x00000001
    \
    $00 constant BSEC_SWLOCK                    \ [0x00 : 32] SWLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK0_DEF
    \
    \ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] SRLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK1_DEF
    \
    \ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] SRLOCK
  [then]


  [ifdef] BSEC_BSEC_OTP_SRLOCK2_DEF
    \
    \ @brief BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK                    \ [0x00 : 32] SRLOCK
  [then]


  [ifdef] BSEC_BSEC_JTAGIN_DEF
    \
    \ @brief BSEC JTAG input register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 16] DATA
  [then]


  [ifdef] BSEC_BSEC_JTAGOUT_DEF
    \
    \ @brief BSEC JTAG output register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 16] DATA
  [then]


  [ifdef] BSEC_BSEC_SCRATCH_DEF
    \
    \ @brief BSEC scratch register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA0_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA1_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA2_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA3_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA4_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA5_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA6_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA7_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA8_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA9_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA10_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA11_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA12_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA13_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA14_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA15_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA16_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA17_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA18_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA19_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA20_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA21_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA22_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA23_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA24_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA25_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA26_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA27_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA28_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA29_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA30_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA31_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA32_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA33_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA34_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA35_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA36_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA37_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA38_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA39_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA40_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA41_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA42_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA43_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA44_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA45_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA46_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA47_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA48_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA49_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA50_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA51_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA52_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA53_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA54_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA55_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA56_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA57_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA58_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA59_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA60_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA61_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA62_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA63_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA64_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA65_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA66_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA67_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA68_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA69_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA70_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA71_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA72_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA73_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA74_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA75_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA76_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA77_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA78_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA79_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA80_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA81_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA82_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA83_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA84_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA85_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA86_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA87_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA88_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA89_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA90_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA91_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA92_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA93_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA94_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_OTP_DATA95_DEF
    \
    \ @brief Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_DATA                      \ [0x00 : 32] DATA
  [then]


  [ifdef] BSEC_BSEC_HWCFGR_DEF
    \
    \ @brief BSEC hardware configuration register
    \ Address offset: 0xFF0
    \ Reset value: 0x00000014
    \
    $00 constant BSEC_SIZE                      \ [0x00 : 4] SIZE
    $04 constant BSEC_ECC_USE                   \ [0x04 : 4] ECC_USE
  [then]


  [ifdef] BSEC_BSEC_VERR_DEF
    \
    \ @brief BSEC version register
    \ Address offset: 0xFF4
    \ Reset value: 0x00000011
    \
    $00 constant BSEC_MINREV                    \ [0x00 : 4] MINREV
    $04 constant BSEC_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] BSEC_BSEC_IPIDR_DEF
    \
    \ @brief BSEC identification register
    \ Address offset: 0xFF8
    \ Reset value: 0x00100032
    \
    $00 constant BSEC_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] BSEC_BSEC_SIDR_DEF
    \
    \ @brief BSEC size identification register
    \ Address offset: 0xFFC
    \ Reset value: 0xA3C5DD04
    \
    $00 constant BSEC_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief BSEC2
  \
  $00 constant BSEC_BSEC_OTP_CONFIG     \ BSEC OTP configuration register
  $04 constant BSEC_BSEC_OTP_CONTROL    \ BSEC OTP control register
  $08 constant BSEC_BSEC_OTP_WRDATA     \ BSEC OTP write data register
  $0C constant BSEC_BSEC_OTP_STATUS     \ BSEC OTP status register
  $10 constant BSEC_BSEC_OTP_LOCK       \ BSEC OTP lock configuration register
  $14 constant BSEC_BSEC_DENABLE        \ reset value depends on OTP secure mode according toTable18: BSEC_DENABLE default values after reset on page181.
  $1C constant BSEC_BSEC_OTP_DISTURBED0 \ BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
  $20 constant BSEC_BSEC_OTP_DISTURBED1 \ BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
  $24 constant BSEC_BSEC_OTP_DISTURBED2 \ BSEC_OTP_DISTURBED0 is used to report disturbed state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP). BSEC_OTP_DISTURBED1 is used to report disturbed state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_DISTURBED2 is used to report disturbed state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95.
  $34 constant BSEC_BSEC_OTP_ERROR0     \ BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
  $38 constant BSEC_BSEC_OTP_ERROR1     \ BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
  $3C constant BSEC_BSEC_OTP_ERROR2     \ BSEC_OTP_ERROR0 is used to report error state of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 (lower 1Kbits OTP which are protected by 2:1 redundancy). BSEC_OTP_ERROR1 is used to report error state of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 which are protected by 6-bit ECC. BSEC_OTP_ERROR2 is used to report error state of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 which are protected by 6-bit ECC.
  $4C constant BSEC_BSEC_OTP_WRLOCK0    \ BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
  $50 constant BSEC_BSEC_OTP_WRLOCK1    \ BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
  $54 constant BSEC_BSEC_OTP_WRLOCK2    \ BSEC_OTP_WLOCK0 is used to report permanent write lock of BSEC_OTP_DATA0 to BSEC_OTP_DATA31. BSEC_OTP_WLOCK1 is used to report permanent write lock of BSEC_OTP_DATA32 to BSEC_OTP_DATA63. BSEC_OTP_WLOCK2 is used to report permanent write lock of BSEC_OTP_DATA64 to BSEC_OTP_DATA95. Permanent write lock requires a programming sequence to lock a word (see section:Section3.3.6: OTP operations on page178).
  $64 constant BSEC_BSEC_OTP_SPLOCK0    \ BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
  $68 constant BSEC_BSEC_OTP_SPLOCK1    \ BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
  $6C constant BSEC_BSEC_OTP_SPLOCK2    \ BSEC_OTP_SPLOCK0 is used to lock the programming of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset BSEC_OTP_SPLOCK1 is used to lock the programming of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset BSEC_OTP_SPLOCK2 is used to lock the programming of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset Attempt to sticky program locked OTP word are silently ignored.
  $7C constant BSEC_BSEC_OTP_SWLOCK0    \ BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
  $80 constant BSEC_BSEC_OTP_SWLOCK1    \ BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
  $84 constant BSEC_BSEC_OTP_SWLOCK2    \ BSEC_OTP_SWLOCK0 is used to prevent writing to BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SWLOCK1 is used to prevent writing to BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SWLOCK2 is used to prevent writing to BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Write to shadow write locked BSEC_OTP_DATA word are silently ignored. Writing to OTP word 0 shadow is always prevented.
  $94 constant BSEC_BSEC_OTP_SRLOCK0    \ BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
  $98 constant BSEC_BSEC_OTP_SRLOCK1    \ BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
  $9C constant BSEC_BSEC_OTP_SRLOCK2    \ BSEC_OTP_SRLOCK0 is used to prevent reloading of BSEC_OTP_DATA0 to BSEC_OTP_DATA31 until next system-reset. BSEC_OTP_SRLOCK1 is used to prevent reloading of BSEC_OTP_DATA32 to BSEC_OTP_DATA63 until next system-reset. BSEC_OTP_SRLOCK2 is used to prevent reloading of BSEC_OTP_DATA64 to BSEC_OTP_DATA95 until next system-reset. Setting SRLOCK bits or attempt to reload a locked OTP do not clear the corresponding BSEC_OTP_DATAx shadow register. BSEC_OTP_SRLOCK0 bit 0 is controlled by hardware according to fuse_ok, writing to this bit has no effect.
  $AC constant BSEC_BSEC_JTAGIN         \ BSEC JTAG input register
  $B0 constant BSEC_BSEC_JTAGOUT        \ BSEC JTAG output register
  $B4 constant BSEC_BSEC_SCRATCH        \ BSEC scratch register
  $200 constant BSEC_BSEC_OTP_DATA0     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $204 constant BSEC_BSEC_OTP_DATA1     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $208 constant BSEC_BSEC_OTP_DATA2     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $20C constant BSEC_BSEC_OTP_DATA3     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $210 constant BSEC_BSEC_OTP_DATA4     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $214 constant BSEC_BSEC_OTP_DATA5     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $218 constant BSEC_BSEC_OTP_DATA6     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $21C constant BSEC_BSEC_OTP_DATA7     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $220 constant BSEC_BSEC_OTP_DATA8     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $224 constant BSEC_BSEC_OTP_DATA9     \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $228 constant BSEC_BSEC_OTP_DATA10    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $22C constant BSEC_BSEC_OTP_DATA11    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $230 constant BSEC_BSEC_OTP_DATA12    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $234 constant BSEC_BSEC_OTP_DATA13    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $238 constant BSEC_BSEC_OTP_DATA14    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $23C constant BSEC_BSEC_OTP_DATA15    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $240 constant BSEC_BSEC_OTP_DATA16    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $244 constant BSEC_BSEC_OTP_DATA17    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $248 constant BSEC_BSEC_OTP_DATA18    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $24C constant BSEC_BSEC_OTP_DATA19    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $250 constant BSEC_BSEC_OTP_DATA20    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $254 constant BSEC_BSEC_OTP_DATA21    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $258 constant BSEC_BSEC_OTP_DATA22    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $25C constant BSEC_BSEC_OTP_DATA23    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $260 constant BSEC_BSEC_OTP_DATA24    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $264 constant BSEC_BSEC_OTP_DATA25    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $268 constant BSEC_BSEC_OTP_DATA26    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $26C constant BSEC_BSEC_OTP_DATA27    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $270 constant BSEC_BSEC_OTP_DATA28    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $274 constant BSEC_BSEC_OTP_DATA29    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $278 constant BSEC_BSEC_OTP_DATA30    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $27C constant BSEC_BSEC_OTP_DATA31    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $280 constant BSEC_BSEC_OTP_DATA32    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $284 constant BSEC_BSEC_OTP_DATA33    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $288 constant BSEC_BSEC_OTP_DATA34    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $28C constant BSEC_BSEC_OTP_DATA35    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $290 constant BSEC_BSEC_OTP_DATA36    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $294 constant BSEC_BSEC_OTP_DATA37    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $298 constant BSEC_BSEC_OTP_DATA38    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $29C constant BSEC_BSEC_OTP_DATA39    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2A0 constant BSEC_BSEC_OTP_DATA40    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2A4 constant BSEC_BSEC_OTP_DATA41    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2A8 constant BSEC_BSEC_OTP_DATA42    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2AC constant BSEC_BSEC_OTP_DATA43    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2B0 constant BSEC_BSEC_OTP_DATA44    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2B4 constant BSEC_BSEC_OTP_DATA45    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2B8 constant BSEC_BSEC_OTP_DATA46    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2BC constant BSEC_BSEC_OTP_DATA47    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2C0 constant BSEC_BSEC_OTP_DATA48    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2C4 constant BSEC_BSEC_OTP_DATA49    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2C8 constant BSEC_BSEC_OTP_DATA50    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2CC constant BSEC_BSEC_OTP_DATA51    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2D0 constant BSEC_BSEC_OTP_DATA52    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2D4 constant BSEC_BSEC_OTP_DATA53    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2D8 constant BSEC_BSEC_OTP_DATA54    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2DC constant BSEC_BSEC_OTP_DATA55    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2E0 constant BSEC_BSEC_OTP_DATA56    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2E4 constant BSEC_BSEC_OTP_DATA57    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2E8 constant BSEC_BSEC_OTP_DATA58    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2EC constant BSEC_BSEC_OTP_DATA59    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2F0 constant BSEC_BSEC_OTP_DATA60    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2F4 constant BSEC_BSEC_OTP_DATA61    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2F8 constant BSEC_BSEC_OTP_DATA62    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $2FC constant BSEC_BSEC_OTP_DATA63    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $300 constant BSEC_BSEC_OTP_DATA64    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $304 constant BSEC_BSEC_OTP_DATA65    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $308 constant BSEC_BSEC_OTP_DATA66    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $30C constant BSEC_BSEC_OTP_DATA67    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $310 constant BSEC_BSEC_OTP_DATA68    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $314 constant BSEC_BSEC_OTP_DATA69    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $318 constant BSEC_BSEC_OTP_DATA70    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $31C constant BSEC_BSEC_OTP_DATA71    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $320 constant BSEC_BSEC_OTP_DATA72    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $324 constant BSEC_BSEC_OTP_DATA73    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $328 constant BSEC_BSEC_OTP_DATA74    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $32C constant BSEC_BSEC_OTP_DATA75    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $330 constant BSEC_BSEC_OTP_DATA76    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $334 constant BSEC_BSEC_OTP_DATA77    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $338 constant BSEC_BSEC_OTP_DATA78    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $33C constant BSEC_BSEC_OTP_DATA79    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $340 constant BSEC_BSEC_OTP_DATA80    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $344 constant BSEC_BSEC_OTP_DATA81    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $348 constant BSEC_BSEC_OTP_DATA82    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $34C constant BSEC_BSEC_OTP_DATA83    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $350 constant BSEC_BSEC_OTP_DATA84    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $354 constant BSEC_BSEC_OTP_DATA85    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $358 constant BSEC_BSEC_OTP_DATA86    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $35C constant BSEC_BSEC_OTP_DATA87    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $360 constant BSEC_BSEC_OTP_DATA88    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $364 constant BSEC_BSEC_OTP_DATA89    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $368 constant BSEC_BSEC_OTP_DATA90    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $36C constant BSEC_BSEC_OTP_DATA91    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $370 constant BSEC_BSEC_OTP_DATA92    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $374 constant BSEC_BSEC_OTP_DATA93    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $378 constant BSEC_BSEC_OTP_DATA94    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $37C constant BSEC_BSEC_OTP_DATA95    \ Several OTP directly impact BSEC behavior, such as: BSEC_OTP_DATA0[6:0] (see Table15: OTP modes definition on page175) BSEC_OTP_DATA1, 16 lsb used for SoC features control BSEC_OTP_DATA2, 2 lsb used to control the RAM handling The reset value depends on the actual OTP programmed value and the OTP mode.
  $FF0 constant BSEC_BSEC_HWCFGR        \ BSEC hardware configuration register
  $FF4 constant BSEC_BSEC_VERR          \ BSEC version register
  $FF8 constant BSEC_BSEC_IPIDR         \ BSEC identification register
  $FFC constant BSEC_BSEC_SIDR          \ BSEC size identification register

: BSEC_DEF ; [then]
